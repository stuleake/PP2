﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TQ.Data.FormEngine.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class RemovedDBO_Unused_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationQuestionSetMappings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApplicationTypes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "QuestionSets",
                schema: "dbo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ApplicationTypes",
                schema: "dbo",
                columns: table => new
                {
                    ApplicationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTypes", x => x.ApplicationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionSets",
                schema: "dbo",
                columns: table => new
                {
                    QuestionSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSets", x => x.QuestionSetId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationQuestionSetMappings",
                schema: "dbo",
                columns: table => new
                {
                    MappingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    QuestionSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationQuestionSetMappings", x => x.MappingId);
                    table.ForeignKey(
                        name: "FK_ApplicationQuestionSetMappings_ApplicationTypes_ApplicationTypeId",
                        column: x => x.ApplicationTypeId,
                        principalSchema: "dbo",
                        principalTable: "ApplicationTypes",
                        principalColumn: "ApplicationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationQuestionSetMappings_QuestionSets_QuestionSetId",
                        column: x => x.QuestionSetId,
                        principalSchema: "dbo",
                        principalTable: "QuestionSets",
                        principalColumn: "QuestionSetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationQuestionSetMappings_ApplicationTypeId",
                schema: "dbo",
                table: "ApplicationQuestionSetMappings",
                column: "ApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationQuestionSetMappings_QuestionSetId",
                schema: "dbo",
                table: "ApplicationQuestionSetMappings",
                column: "QuestionSetId");
        }
    }
}