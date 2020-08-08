using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class updatemycontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Account",
                columns: table => new
                {
                    id_account = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    access_level = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Account", x => x.id_account);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Konsumen",
                columns: table => new
                {
                    id_konsumen = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nama = table.Column<string>(nullable: true),
                    alamat = table.Column<string>(nullable: true),
                    tlp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Konsumen", x => x.id_konsumen);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Merk",
                columns: table => new
                {
                    id_merk = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    merk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Merk", x => x.id_merk);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Car",
                columns: table => new
                {
                    id_car = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nm_car = table.Column<string>(nullable: true),
                    transmition = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    merkid_merk = table.Column<int>(nullable: true),
                    accountid_account = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Car", x => x.id_car);
                    table.ForeignKey(
                        name: "FK_Tbl_Car_Tbl_Account_accountid_account",
                        column: x => x.accountid_account,
                        principalTable: "Tbl_Account",
                        principalColumn: "id_account",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Car_Tbl_Merk_merkid_merk",
                        column: x => x.merkid_merk,
                        principalTable: "Tbl_Merk",
                        principalColumn: "id_merk",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Reserve",
                columns: table => new
                {
                    id_reserve = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    total = table.Column<int>(nullable: false),
                    tgl_bayar = table.Column<DateTime>(nullable: false),
                    carid_car = table.Column<int>(nullable: true),
                    konsumenid_konsumen = table.Column<int>(nullable: true),
                    accountid_account = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Reserve", x => x.id_reserve);
                    table.ForeignKey(
                        name: "FK_Tbl_Reserve_Tbl_Account_accountid_account",
                        column: x => x.accountid_account,
                        principalTable: "Tbl_Account",
                        principalColumn: "id_account",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Reserve_Tbl_Car_carid_car",
                        column: x => x.carid_car,
                        principalTable: "Tbl_Car",
                        principalColumn: "id_car",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Reserve_Tbl_Konsumen_konsumenid_konsumen",
                        column: x => x.konsumenid_konsumen,
                        principalTable: "Tbl_Konsumen",
                        principalColumn: "id_konsumen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Car_accountid_account",
                table: "Tbl_Car",
                column: "accountid_account");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Car_merkid_merk",
                table: "Tbl_Car",
                column: "merkid_merk");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Reserve_accountid_account",
                table: "Tbl_Reserve",
                column: "accountid_account");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Reserve_carid_car",
                table: "Tbl_Reserve",
                column: "carid_car");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Reserve_konsumenid_konsumen",
                table: "Tbl_Reserve",
                column: "konsumenid_konsumen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Reserve");

            migrationBuilder.DropTable(
                name: "Tbl_Car");

            migrationBuilder.DropTable(
                name: "Tbl_Konsumen");

            migrationBuilder.DropTable(
                name: "Tbl_Account");

            migrationBuilder.DropTable(
                name: "Tbl_Merk");
        }
    }
}
