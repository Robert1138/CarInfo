using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserCars",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Car = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCars", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Psswd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    barrels08 = table.Column<double>(nullable: false),
                    barrelsA08 = table.Column<double>(nullable: false),
                    charge120 = table.Column<double>(nullable: false),
                    charge240 = table.Column<double>(nullable: false),
                    city08 = table.Column<int>(nullable: false),
                    city08U = table.Column<double>(nullable: false),
                    cityA08 = table.Column<double>(nullable: false),
                    cityA08U = table.Column<double>(nullable: false),
                    cityCD = table.Column<double>(nullable: false),
                    cityE = table.Column<double>(nullable: false),
                    cityUF = table.Column<double>(nullable: false),
                    co2 = table.Column<double>(nullable: false),
                    co2A = table.Column<double>(nullable: false),
                    co2TailpipeAGpm = table.Column<double>(nullable: false),
                    co2TailpipeGpm = table.Column<double>(nullable: false),
                    comb08 = table.Column<int>(nullable: false),
                    comb08U = table.Column<double>(nullable: false),
                    combA08 = table.Column<double>(nullable: false),
                    combA08U = table.Column<double>(nullable: false),
                    combE = table.Column<double>(nullable: false),
                    combinedCD = table.Column<double>(nullable: false),
                    combinedUF = table.Column<double>(nullable: false),
                    cylinders = table.Column<int>(nullable: false),
                    displ = table.Column<double>(nullable: false),
                    drive = table.Column<string>(nullable: true),
                    engId = table.Column<int>(nullable: false),
                    eng_dscr = table.Column<string>(nullable: true),
                    feScore = table.Column<int>(nullable: false),
                    fuelCost08 = table.Column<int>(nullable: false),
                    fuelCostA08 = table.Column<int>(nullable: false),
                    fuelType = table.Column<string>(nullable: true),
                    fuelType1 = table.Column<string>(nullable: true),
                    ghgScore = table.Column<int>(nullable: false),
                    ghgScoreA = table.Column<int>(nullable: false),
                    highway08 = table.Column<double>(nullable: false),
                    highway08U = table.Column<double>(nullable: false),
                    highwayA08 = table.Column<double>(nullable: false),
                    highwayA08U = table.Column<double>(nullable: false),
                    highwayCD = table.Column<double>(nullable: false),
                    highwayE = table.Column<double>(nullable: false),
                    highwayUF = table.Column<double>(nullable: false),
                    hlv = table.Column<double>(nullable: false),
                    hpv = table.Column<double>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    lv2 = table.Column<double>(nullable: false),
                    lv4 = table.Column<double>(nullable: false),
                    make = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    mpgData = table.Column<string>(nullable: true),
                    phevBlended = table.Column<string>(nullable: true),
                    pv2 = table.Column<double>(nullable: false),
                    pv4 = table.Column<double>(nullable: false),
                    range = table.Column<int>(nullable: false),
                    rangeCity = table.Column<double>(nullable: false),
                    rangeCityA = table.Column<double>(nullable: false),
                    rangeHwy = table.Column<double>(nullable: false),
                    trany = table.Column<string>(nullable: true),
                    UCity = table.Column<double>(nullable: false),
                    UCityA = table.Column<double>(nullable: false),
                    UHighway = table.Column<double>(nullable: false),
                    UHighwayA = table.Column<double>(nullable: false),
                    VClass = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    youSaveSpend = table.Column<int>(nullable: false),
                    guzzler = table.Column<string>(nullable: true),
                    trans_dscr = table.Column<string>(nullable: true),
                    tCharger = table.Column<string>(nullable: true),
                    sCharger = table.Column<string>(nullable: true),
                    atvType = table.Column<string>(nullable: true),
                    fuelType2 = table.Column<string>(nullable: true),
                    rangeA = table.Column<double>(nullable: false),
                    evMotor = table.Column<string>(nullable: true),
                    mfrCode = table.Column<string>(nullable: true),
                    c240Dscr = table.Column<string>(nullable: true),
                    charge240b = table.Column<double>(nullable: false),
                    c240bDscr = table.Column<string>(nullable: true),
                    createdOn = table.Column<string>(nullable: true),
                    modifiedOn = table.Column<string>(nullable: true),
                    startStop = table.Column<string>(nullable: true),
                    phevCity = table.Column<double>(nullable: false),
                    phevHwy = table.Column<double>(nullable: false),
                    phevComb = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
