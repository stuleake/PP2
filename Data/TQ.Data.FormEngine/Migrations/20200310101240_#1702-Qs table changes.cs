﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace TQ.Data.FormEngine.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class _1702Qstablechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "sessions",
                table: "QSRAnswers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RowNo",
                schema: "sessions",
                table: "QSRAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationTypeRefNo",
                schema: "sessions",
                table: "QSCollections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "QSCollectionVersion",
                schema: "sessions",
                table: "QSCollections",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationTypeRefNo",
                schema: "forms",
                table: "QSCollectionTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "QSCollectionVersion",
                schema: "forms",
                table: "QSCollectionTypes",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "sessions",
                table: "QSRAnswers");

            migrationBuilder.DropColumn(
                name: "RowNo",
                schema: "sessions",
                table: "QSRAnswers");

            migrationBuilder.DropColumn(
                name: "ApplicationTypeRefNo",
                schema: "sessions",
                table: "QSCollections");

            migrationBuilder.DropColumn(
                name: "QSCollectionVersion",
                schema: "sessions",
                table: "QSCollections");

            migrationBuilder.DropColumn(
                name: "ApplicationTypeRefNo",
                schema: "forms",
                table: "QSCollectionTypes");

            migrationBuilder.DropColumn(
                name: "QSCollectionVersion",
                schema: "forms",
                table: "QSCollectionTypes");
        }
    }
}