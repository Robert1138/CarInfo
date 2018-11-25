﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Data;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(VehiclesContext))]
    [Migration("20181120044721_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("WebApplication3.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Psswd");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication3.Models.UserCar", b =>
                {
                    b.Property<string>("UserName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Car");

                    b.HasKey("UserName");

                    b.ToTable("UserCars");
                });

            modelBuilder.Entity("WebApplication3.Models.vehiclesFEGOV", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("UCity");

                    b.Property<double>("UCityA");

                    b.Property<double>("UHighway");

                    b.Property<double>("UHighwayA");

                    b.Property<string>("VClass");

                    b.Property<string>("atvType");

                    b.Property<double>("barrels08");

                    b.Property<double>("barrelsA08");

                    b.Property<string>("c240Dscr");

                    b.Property<string>("c240bDscr");

                    b.Property<double>("charge120");

                    b.Property<double>("charge240");

                    b.Property<double>("charge240b");

                    b.Property<int>("city08");

                    b.Property<double>("city08U");

                    b.Property<double>("cityA08");

                    b.Property<double>("cityA08U");

                    b.Property<double>("cityCD");

                    b.Property<double>("cityE");

                    b.Property<double>("cityUF");

                    b.Property<double>("co2");

                    b.Property<double>("co2A");

                    b.Property<double>("co2TailpipeAGpm");

                    b.Property<double>("co2TailpipeGpm");

                    b.Property<int>("comb08");

                    b.Property<double>("comb08U");

                    b.Property<double>("combA08");

                    b.Property<double>("combA08U");

                    b.Property<double>("combE");

                    b.Property<double>("combinedCD");

                    b.Property<double>("combinedUF");

                    b.Property<string>("createdOn");

                    b.Property<int>("cylinders");

                    b.Property<double>("displ");

                    b.Property<string>("drive");

                    b.Property<int>("engId");

                    b.Property<string>("eng_dscr");

                    b.Property<string>("evMotor");

                    b.Property<int>("feScore");

                    b.Property<int>("fuelCost08");

                    b.Property<int>("fuelCostA08");

                    b.Property<string>("fuelType");

                    b.Property<string>("fuelType1");

                    b.Property<string>("fuelType2");

                    b.Property<int>("ghgScore");

                    b.Property<int>("ghgScoreA");

                    b.Property<string>("guzzler");

                    b.Property<double>("highway08");

                    b.Property<double>("highway08U");

                    b.Property<double>("highwayA08");

                    b.Property<double>("highwayA08U");

                    b.Property<double>("highwayCD");

                    b.Property<double>("highwayE");

                    b.Property<double>("highwayUF");

                    b.Property<double>("hlv");

                    b.Property<double>("hpv");

                    b.Property<double>("lv2");

                    b.Property<double>("lv4");

                    b.Property<string>("make");

                    b.Property<string>("mfrCode");

                    b.Property<string>("model");

                    b.Property<string>("modifiedOn");

                    b.Property<string>("mpgData");

                    b.Property<string>("phevBlended");

                    b.Property<double>("phevCity");

                    b.Property<double>("phevComb");

                    b.Property<double>("phevHwy");

                    b.Property<double>("pv2");

                    b.Property<double>("pv4");

                    b.Property<int>("range");

                    b.Property<double>("rangeA");

                    b.Property<double>("rangeCity");

                    b.Property<double>("rangeCityA");

                    b.Property<double>("rangeHwy");

                    b.Property<string>("sCharger");

                    b.Property<string>("startStop");

                    b.Property<string>("tCharger");

                    b.Property<string>("trans_dscr");

                    b.Property<string>("trany");

                    b.Property<int>("year");

                    b.Property<int>("youSaveSpend");

                    b.HasKey("id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
