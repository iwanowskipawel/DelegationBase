using Microsoft.EntityFrameworkCore.Migrations;

namespace Delegation.Migrations
{
    public partial class OderTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Car_CarID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Destination_DestinationID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Employee_DriverEmployeeID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Employee_KeeperEmployeeID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_KilometersCard_KilometersCardID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Project_ProjectID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Employee_MainDriverEmployeeID",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_AddressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Address_AddressID",
                table: "Destination");

            migrationBuilder.DropForeignKey(
                name: "FK_KilometersCard_Car_CarID",
                table: "KilometersCard");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Company_CompanyID",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KilometersCard",
                table: "KilometersCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destination",
                table: "Destination");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "KilometersCard",
                newName: "KilometersCards");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Destination",
                newName: "Destinations");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Project_CompanyID",
                table: "Projects",
                newName: "IX_Projects_CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_KilometersCard_CarID",
                table: "KilometersCards",
                newName: "IX_KilometersCards_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Destination_AddressID",
                table: "Destinations",
                newName: "IX_Destinations_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_AddressID",
                table: "Companies",
                newName: "IX_Companies_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_MainDriverEmployeeID",
                table: "Cars",
                newName: "IX_Cars_MainDriverEmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KilometersCards",
                table: "KilometersCards",
                column: "KilometersCardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations",
                column: "DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Cars_CarID",
                table: "BusinessTrips",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Destinations_DestinationID",
                table: "BusinessTrips",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Employees_DriverEmployeeID",
                table: "BusinessTrips",
                column: "DriverEmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Employees_KeeperEmployeeID",
                table: "BusinessTrips",
                column: "KeeperEmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_KilometersCards_KilometersCardID",
                table: "BusinessTrips",
                column: "KilometersCardID",
                principalTable: "KilometersCards",
                principalColumn: "KilometersCardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Projects_ProjectID",
                table: "BusinessTrips",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Employees_MainDriverEmployeeID",
                table: "Cars",
                column: "MainDriverEmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Addresses_AddressID",
                table: "Companies",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Addresses_AddressID",
                table: "Destinations",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KilometersCards_Cars_CarID",
                table: "KilometersCards",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Companies_CompanyID",
                table: "Projects",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Cars_CarID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Destinations_DestinationID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Employees_DriverEmployeeID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Employees_KeeperEmployeeID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_KilometersCards_KilometersCardID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_Projects_ProjectID",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Employees_MainDriverEmployeeID",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Addresses_AddressID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Addresses_AddressID",
                table: "Destinations");

            migrationBuilder.DropForeignKey(
                name: "FK_KilometersCards_Cars_CarID",
                table: "KilometersCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Companies_CompanyID",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KilometersCards",
                table: "KilometersCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinations",
                table: "Destinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "KilometersCards",
                newName: "KilometersCard");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Destinations",
                newName: "Destination");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CompanyID",
                table: "Project",
                newName: "IX_Project_CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_KilometersCards_CarID",
                table: "KilometersCard",
                newName: "IX_KilometersCard_CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Destinations_AddressID",
                table: "Destination",
                newName: "IX_Destination_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_AddressID",
                table: "Company",
                newName: "IX_Company_AddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_MainDriverEmployeeID",
                table: "Car",
                newName: "IX_Car_MainDriverEmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KilometersCard",
                table: "KilometersCard",
                column: "KilometersCardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destination",
                table: "Destination",
                column: "DestinationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "CarID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Car_CarID",
                table: "BusinessTrips",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Destination_DestinationID",
                table: "BusinessTrips",
                column: "DestinationID",
                principalTable: "Destination",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Employee_DriverEmployeeID",
                table: "BusinessTrips",
                column: "DriverEmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Employee_KeeperEmployeeID",
                table: "BusinessTrips",
                column: "KeeperEmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_KilometersCard_KilometersCardID",
                table: "BusinessTrips",
                column: "KilometersCardID",
                principalTable: "KilometersCard",
                principalColumn: "KilometersCardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_Project_ProjectID",
                table: "BusinessTrips",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Employee_MainDriverEmployeeID",
                table: "Car",
                column: "MainDriverEmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_AddressID",
                table: "Company",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Address_AddressID",
                table: "Destination",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KilometersCard_Car_CarID",
                table: "KilometersCard",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Company_CompanyID",
                table: "Project",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
