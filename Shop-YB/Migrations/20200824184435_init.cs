using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopYB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    FullName = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Category",
                        column: x => x.ParentId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TermPolicy = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Describe = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    RecordNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contactus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsRead = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayMethod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Method = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SlideShow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlideShow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRewardPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    Reward_Points = table.Column<int>(nullable: false),
                    Reward_Type = table.Column<string>(nullable: true),
                    OPeration_Type = table.Column<string>(nullable: true),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Expairy_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRewardPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressTable_Account",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Account",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Featured = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    View = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Product",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_Category_Discount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Category_Id = table.Column<int>(nullable: false),
                    Discount_Value = table.Column<int>(nullable: false),
                    Discount_Unit = table.Column<string>(nullable: true),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Valid_From = table.Column<DateTime>(nullable: false),
                    Valid_Until = table.Column<DateTime>(nullable: false),
                    Coupon_Code = table.Column<string>(nullable: true),
                    Min_Order_Value = table.Column<int>(nullable: false),
                    Max_Discount_Amount = table.Column<int>(nullable: false),
                    Is_Redeem_Allowed = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Category_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_Discount_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleAccount",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAccount_Tbl", x => new { x.RoleId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_RoleAccount_Tbl_Account_Tbl",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleAccount_Tbl_Role_Tbl",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PayMethodId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    AccountId = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Product",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PayMethod",
                        column: x => x.PayMethodId,
                        principalTable: "PayMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ShipMethod = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => new { x.InvoiceId, x.AddressId });
                    table.UniqueConstraint("AK_Ship_AddressId_InvoiceId", x => new { x.AddressId, x.InvoiceId });
                    table.ForeignKey(
                        name: "FK_Ship_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ship_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    Date_Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => new { x.InvoiceId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoice",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    DiscountValue = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ExpirayDate = table.Column<DateTime>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDiscount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PDiscount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Featured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Photo",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_Discount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_Id = table.Column<int>(nullable: false),
                    Discount_Value = table.Column<int>(nullable: false),
                    Discount_Unit = table.Column<string>(nullable: true),
                    Create_Date = table.Column<DateTime>(nullable: false),
                    Valid_From = table.Column<DateTime>(nullable: false),
                    Valid_Until = table.Column<DateTime>(nullable: false),
                    Coupon_Code = table.Column<string>(nullable: true),
                    Min_Order_Value = table.Column<int>(nullable: false),
                    Max_Discount_Amount = table.Column<int>(nullable: false),
                    Is_Redeem_Allowed = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Discount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product_Price",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    BasePrice = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ExpirayDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Price", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Price_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeDislike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserIp = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CommentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeDislike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikeDislike_Comment",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AccountId",
                table: "Address",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentId",
                table: "Category",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_AccountId",
                table: "Invoice",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeDislike_CommentId",
                table: "LikeDislike",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_AccountId",
                table: "Payment",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_InvoiceId",
                table: "Payment",
                column: "InvoiceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PayMethodId",
                table: "Payment",
                column: "PayMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PDiscount_ProductId",
                table: "PDiscount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ProductId",
                table: "Photo",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Discount_CategoryId",
                table: "Product_Category_Discount",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Discount_ProductId",
                table: "Product_Discount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Price_ProductId",
                table: "Product_Price",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccount_AccountId",
                table: "RoleAccount",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Ship_InvoiceId",
                table: "Ship",
                column: "InvoiceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "Contactus");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "LikeDislike");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PDiscount");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Product_Category_Discount");

            migrationBuilder.DropTable(
                name: "Product_Discount");

            migrationBuilder.DropTable(
                name: "Product_Price");

            migrationBuilder.DropTable(
                name: "RoleAccount");

            migrationBuilder.DropTable(
                name: "Ship");

            migrationBuilder.DropTable(
                name: "SlideShow");

            migrationBuilder.DropTable(
                name: "UserRewardPoints");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "PayMethod");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
