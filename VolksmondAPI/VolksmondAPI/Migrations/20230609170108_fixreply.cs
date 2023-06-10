﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VolksmondAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixreply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Reply_ReplyId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyVote_Reply_Reply",
                table: "ReplyVote");

            migrationBuilder.DropIndex(
                name: "IX_ReplyVote_Reply",
                table: "ReplyVote");

            migrationBuilder.DropIndex(
                name: "IX_Reply_ReplyId",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "Reply",
                table: "ReplyVote");

            migrationBuilder.AddColumn<int>(
                name: "Reply",
                table: "Reply",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReplyVote_ReplyId",
                table: "ReplyVote",
                column: "ReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_CitizenId",
                table: "Reply",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_Reply",
                table: "Reply",
                column: "Reply");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Citizen_CitizenId",
                table: "Reply",
                column: "CitizenId",
                principalTable: "Citizen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Reply_Reply",
                table: "Reply",
                column: "Reply",
                principalTable: "Reply",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyVote_Reply_ReplyId",
                table: "ReplyVote",
                column: "ReplyId",
                principalTable: "Reply",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Citizen_CitizenId",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Reply_Reply",
                table: "Reply");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyVote_Reply_ReplyId",
                table: "ReplyVote");

            migrationBuilder.DropIndex(
                name: "IX_ReplyVote_ReplyId",
                table: "ReplyVote");

            migrationBuilder.DropIndex(
                name: "IX_Reply_CitizenId",
                table: "Reply");

            migrationBuilder.DropIndex(
                name: "IX_Reply_Reply",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "Reply",
                table: "Reply");

            migrationBuilder.AddColumn<int>(
                name: "Reply",
                table: "ReplyVote",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReplyVote_Reply",
                table: "ReplyVote",
                column: "Reply");

            migrationBuilder.CreateIndex(
                name: "IX_Reply_ReplyId",
                table: "Reply",
                column: "ReplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Reply_ReplyId",
                table: "Reply",
                column: "ReplyId",
                principalTable: "Reply",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyVote_Reply_Reply",
                table: "ReplyVote",
                column: "Reply",
                principalTable: "Reply",
                principalColumn: "Id");
        }
    }
}