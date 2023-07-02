using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lyceum.Infrastructure.Ef.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_Components_Id",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_AddCourse_Components_Id",
                table: "AddCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Components_Id",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Components_Id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentСommission_Components_Id",
                table: "ParentСommission");

            migrationBuilder.DropForeignKey(
                name: "FK_Stakeholder_Components_Id",
                table: "Stakeholder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Components",
                table: "Components");

            migrationBuilder.RenameTable(
                name: "Components",
                newName: "Component");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Component",
                table: "Component",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_Component_Id",
                table: "Achievement",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddCourse_Component_Id",
                table: "AddCourse",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Component_Id",
                table: "History",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Component_Id",
                table: "News",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentСommission_Component_Id",
                table: "ParentСommission",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stakeholder_Component_Id",
                table: "Stakeholder",
                column: "Id",
                principalTable: "Component",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_Component_Id",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_AddCourse_Component_Id",
                table: "AddCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Component_Id",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Component_Id",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_ParentСommission_Component_Id",
                table: "ParentСommission");

            migrationBuilder.DropForeignKey(
                name: "FK_Stakeholder_Component_Id",
                table: "Stakeholder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Component",
                table: "Component");

            migrationBuilder.RenameTable(
                name: "Component",
                newName: "Components");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Components",
                table: "Components",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_Components_Id",
                table: "Achievement",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddCourse_Components_Id",
                table: "AddCourse",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_History_Components_Id",
                table: "History",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Components_Id",
                table: "News",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentСommission_Components_Id",
                table: "ParentСommission",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stakeholder_Components_Id",
                table: "Stakeholder",
                column: "Id",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
