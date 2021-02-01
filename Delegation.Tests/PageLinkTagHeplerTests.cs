﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Delegation.Infrastructure;
using Delegation.Models.ViewModels;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Delegation.Tests
{
    public class PageLinkTagHeplerTests
    {
        [Fact]
        public void CanGeneratePageLinks()
        {
            //Arrange
            var urlHelper = new Mock<IUrlHelper>();
            urlHelper.SetupSequence(x => x.Action(It.IsAny<UrlActionContext>()))
                .Returns("Test/Page1")
                .Returns("Test/Page2")
                .Returns("Test/Page3");

            var urlHelperFactory = new Mock<IUrlHelperFactory>();
            urlHelperFactory.Setup(f => f.GetUrlHelper(It.IsAny<ActionContext>()))
                .Returns(urlHelper.Object);

            PageLinkTagHelper helper = new PageLinkTagHelper(urlHelperFactory.Object)
            {
                PageModel = new PagingInfo
                {
                    CurrentPage = 2,
                    TotalItems = 50,
                    ItemsPerPage = 17
                },
                PageAction = "Test"
            };

            TagHelperContext context = new TagHelperContext(
                new TagHelperAttributeList(), 
                new Dictionary<object, object>(),
                "");

            var content = new Mock<TagHelperContent>();
            TagHelperOutput output = new TagHelperOutput("div",
                new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult(content.Object));

            //Act
            helper.Process(context, output);

            //Assert
            Assert.Equal(@"<a href=""Test/Page1"">1</a><a href=""Test/Page2"">2</a><a href=""Test/Page3"">3</a>",
                output.Content.GetContent());
        }
    }
}