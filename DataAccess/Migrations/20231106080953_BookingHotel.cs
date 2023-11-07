﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class BookingHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CusCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CusFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusDob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CusPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    SysDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CusCode);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImgCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    PathServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SysDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImgCode);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuLevel = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    SysDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    NationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    PasswordChanged = table.Column<bool>(type: "bit", nullable: true),
                    LastPasswordChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageImgCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Image_ImageImgCode",
                        column: x => x.ImageImgCode,
                        principalTable: "Image",
                        principalColumn: "ImgCode");
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    ImgCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageImgCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelCode);
                    table.ForeignKey(
                        name: "FK_Hotel_Hotel_ImgCodeByUserId",
                        column: x => x.ImgCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                    table.ForeignKey(
                        name: "FK_Hotel_Image_ImageImgCode",
                        column: x => x.ImageImgCode,
                        principalTable: "Image",
                        principalColumn: "ImgCode");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CusCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HotelCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluate_Customer_CusCodeByUserId",
                        column: x => x.CusCodeByUserId,
                        principalTable: "Customer",
                        principalColumn: "CusCode");
                    table.ForeignKey(
                        name: "FK_Evaluate_Hotel_HotelCodeByUserId",
                        column: x => x.HotelCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                });

            migrationBuilder.CreateTable(
                name: "New",
                columns: table => new
                {
                    NewsCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SumContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountView = table.Column<int>(type: "int", nullable: true),
                    SysDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImgCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    ImageImgCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_New", x => x.NewsCode);
                    table.ForeignKey(
                        name: "FK_New_Hotel_ImgCodeByUserId",
                        column: x => x.ImgCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                    table.ForeignKey(
                        name: "FK_New_Image_ImageImgCode",
                        column: x => x.ImageImgCode,
                        principalTable: "Image",
                        principalColumn: "ImgCode");
                    table.ForeignKey(
                        name: "FK_New_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    RoomMax = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    HotelCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImgCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageImgCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomCode);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelCodeByUserId",
                        column: x => x.HotelCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_ImgCodeByUserId",
                        column: x => x.ImgCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                    table.ForeignKey(
                        name: "FK_Room_Image_ImageImgCode",
                        column: x => x.ImageImgCode,
                        principalTable: "Image",
                        principalColumn: "ImgCode");
                });

            migrationBuilder.CreateTable(
                name: "SaleOff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BeginDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Numbers = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    HotelCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOff_Hotel_HotelCodeByUserId",
                        column: x => x.HotelCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    HotelCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImgCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageImgCode = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceCode);
                    table.ForeignKey(
                        name: "FK_Service_Hotel_HotelCodeByUserId",
                        column: x => x.HotelCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Hotel_ImgCodeByUserId",
                        column: x => x.ImgCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                    table.ForeignKey(
                        name: "FK_Service_Image_ImageImgCode",
                        column: x => x.ImageImgCode,
                        principalTable: "Image",
                        principalColumn: "ImgCode");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Deposit = table.Column<bool>(type: "bit", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CusCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HotelCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoomCodeByUserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookCode);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CusCodeByUserId",
                        column: x => x.CusCodeByUserId,
                        principalTable: "Customer",
                        principalColumn: "CusCode");
                    table.ForeignKey(
                        name: "FK_Booking_Hotel_HotelCodeByUserId",
                        column: x => x.HotelCodeByUserId,
                        principalTable: "Hotel",
                        principalColumn: "HotelCode");
                    table.ForeignKey(
                        name: "FK_Booking_Room_RoomCodeByUserId",
                        column: x => x.RoomCodeByUserId,
                        principalTable: "Room",
                        principalColumn: "RoomCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageImgCode",
                table: "AspNetUsers",
                column: "ImageImgCode");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CusCodeByUserId",
                table: "Booking",
                column: "CusCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_HotelCodeByUserId",
                table: "Booking",
                column: "HotelCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomCodeByUserId",
                table: "Booking",
                column: "RoomCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluate_CusCodeByUserId",
                table: "Evaluate",
                column: "CusCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluate_HotelCodeByUserId",
                table: "Evaluate",
                column: "HotelCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_ImageImgCode",
                table: "Hotel",
                column: "ImageImgCode");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_ImgCodeByUserId",
                table: "Hotel",
                column: "ImgCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_New_ImageImgCode",
                table: "New",
                column: "ImageImgCode");

            migrationBuilder.CreateIndex(
                name: "IX_New_ImgCodeByUserId",
                table: "New",
                column: "ImgCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_New_MenuId",
                table: "New",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelCodeByUserId",
                table: "Room",
                column: "HotelCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_ImageImgCode",
                table: "Room",
                column: "ImageImgCode");

            migrationBuilder.CreateIndex(
                name: "IX_Room_ImgCodeByUserId",
                table: "Room",
                column: "ImgCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOff_HotelCodeByUserId",
                table: "SaleOff",
                column: "HotelCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_HotelCodeByUserId",
                table: "Service",
                column: "HotelCodeByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ImageImgCode",
                table: "Service",
                column: "ImageImgCode");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ImgCodeByUserId",
                table: "Service",
                column: "ImgCodeByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Evaluate");

            migrationBuilder.DropTable(
                name: "New");

            migrationBuilder.DropTable(
                name: "SaleOff");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}