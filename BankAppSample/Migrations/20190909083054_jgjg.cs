using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAppSample.Migrations
{
    public partial class jgjg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRegistrations",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<long>(nullable: false),
                    FullName = table.Column<string>(maxLength: 35, nullable: false),
                    FatherName = table.Column<string>(maxLength: 35, nullable: false),
                    MotherName = table.Column<string>(maxLength: 35, nullable: false),
                    Dateofbirth = table.Column<string>(nullable: false),
                    Age = table.Column<int>(maxLength: 4, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 10, nullable: false),
                    PermanemtAddress = table.Column<string>(maxLength: 150, nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistrations", x => x.RegistrationID);
                });

            migrationBuilder.CreateTable(
                name: "UserTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepositAmount = table.Column<decimal>(nullable: false),
                    WithdrawAmount = table.Column<decimal>(nullable: false),
                    AvailBal = table.Column<decimal>(nullable: false),
                    AccountHolderName = table.Column<string>(nullable: true),
                    DateofTransaction = table.Column<DateTime>(nullable: false),
                    AccountNumber = table.Column<long>(nullable: false),
                    RegistrationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTransaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_UserTransaction_UserRegistrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "UserRegistrations",
                        principalColumn: "RegistrationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTransaction_RegistrationID",
                table: "UserTransaction",
                column: "RegistrationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTransaction");

            migrationBuilder.DropTable(
                name: "UserRegistrations");
        }
    }
}
