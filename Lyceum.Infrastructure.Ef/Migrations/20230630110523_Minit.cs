using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lyceum.Infrastructure.Ef.Migrations
{
    /// <inheritdoc />
    public partial class Minit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Caption = table.Column<string>(type: "text", nullable: true),
                    FullInfo = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<string>(type: "text", nullable: true),
                    DefaultImgId = table.Column<string>(type: "text", nullable: true),
                    Images = table.Column<List<string>>(type: "text[]", nullable: false),
                    Features = table.Column<string>(type: "text", nullable: true),
                    Views = table.Column<string>(type: "text", nullable: true),
                    Likes = table.Column<int>(type: "integer", nullable: true),
                    Dislikes = table.Column<int>(type: "integer", nullable: true),
                    ClassId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Img = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<string>(type: "text", nullable: true),
                    FullInfo = table.Column<string>(type: "text", nullable: true),
                    Features = table.Column<string>(type: "text", nullable: true),
                    JobPosition = table.Column<string>(type: "text", nullable: true),
                    SocialNetwork = table.Column<string>(type: "text", nullable: true),
                    ClassId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Achievement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievement_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddCourse",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CourseDuration = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddCourse_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentСommission",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentСommission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentСommission_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stakeholder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stakeholder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stakeholder_Components_Id",
                        column: x => x.Id,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Persons_Id",
                        column: x => x.Id,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Rank = table.Column<string>(type: "text", nullable: true),
                    AcademicDegree = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Persons_Id",
                        column: x => x.Id,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievement");

            migrationBuilder.DropTable(
                name: "AddCourse");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "ParentСommission");

            migrationBuilder.DropTable(
                name: "Stakeholder");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
