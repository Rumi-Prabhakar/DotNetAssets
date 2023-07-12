using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DNA.Repository.Migrations
{
    public partial class CreateDBDotNetAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "IssueAttachmentType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AttachmentType = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueAttachmentType", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueClassification",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Classification = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueClassification", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueSeverity",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Severity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueSeverity", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueStatus",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueStatus", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfPost = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DevelopmentIssues",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IssueTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        IssueClassificationId = table.Column<int>(type: "int", nullable: false),
            //        CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        StatusId = table.Column<int>(type: "int", nullable: false),
            //        Severity = table.Column<int>(type: "int", nullable: false),
            //        ResolutionDuration = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DevelopmentIssues", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Developme__Issue__34C8D9D1",
            //            column: x => x.IssueClassificationId,
            //            principalTable: "IssueClassification",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Developme__Sever__29572725",
            //            column: x => x.Severity,
            //            principalTable: "IssueSeverity",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__Developme__Statu__286302EC",
            //            column: x => x.StatusId,
            //            principalTable: "IssueStatus",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueResolution",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PostedById = table.Column<int>(type: "int", nullable: false),
            //        DateOfPost = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueResolution", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_IssueResolution_User_PostedById",
            //            column: x => x.PostedById,
            //            principalTable: "User",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueAttachment",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IssueId = table.Column<int>(type: "int", nullable: false),
            //        AttachmentId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        AttachmentTypeId = table.Column<int>(type: "int", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueAttachment", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__IssueAtta__Attac__31EC6D26",
            //            column: x => x.AttachmentTypeId,
            //            principalTable: "IssueAttachmentType",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK__IssueAtta__Issue__30F848ED",
            //            column: x => x.IssueId,
            //            principalTable: "DevelopmentIssues",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "IssueDetail",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IssueId = table.Column<int>(type: "int", nullable: false),
            //        IssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IssueDetail", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__IssueDeta__Issue__2C3393D0",
            //            column: x => x.IssueId,
            //            principalTable: "DevelopmentIssues",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_DevelopmentIssues_IssueClassificationId",
            //    table: "DevelopmentIssues",
            //    column: "IssueClassificationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DevelopmentIssues_Severity",
            //    table: "DevelopmentIssues",
            //    column: "Severity");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DevelopmentIssues_StatusId",
            //    table: "DevelopmentIssues",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IssueAttachment_AttachmentTypeId",
            //    table: "IssueAttachment",
            //    column: "AttachmentTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IssueAttachment_IssueId",
            //    table: "IssueAttachment",
            //    column: "IssueId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IssueDetail_IssueId",
            //    table: "IssueDetail",
            //    column: "IssueId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IssueResolution_PostedById",
            //    table: "IssueResolution",
            //    column: "PostedById");

            //migrationBuilder.CreateIndex(
            //    name: "IX_User_UserId",
            //    table: "User",
            //    column: "UserId",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "IssueAttachment");

            //migrationBuilder.DropTable(
            //    name: "IssueDetail");

            //migrationBuilder.DropTable(
            //    name: "IssueResolution");

            //migrationBuilder.DropTable(
            //    name: "IssueAttachmentType");

            //migrationBuilder.DropTable(
            //    name: "DevelopmentIssues");

            //migrationBuilder.DropTable(
            //    name: "User");

            //migrationBuilder.DropTable(
            //    name: "IssueClassification");

            //migrationBuilder.DropTable(
            //    name: "IssueSeverity");

            //migrationBuilder.DropTable(
            //    name: "IssueStatus");
        }
    }
}
