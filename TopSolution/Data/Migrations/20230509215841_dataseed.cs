using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreateDate", "Description", "HashTags", "OwnerId", "RelatedProgLanguages", "Title", "Type", "Views" },
                values: new object[,]
                {
                    { "015f73e7-32b1-4754-ba45-8f7f5bd52d34", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(255), "Desc 55", null, null, "Cpp", "Title 55", 0, 0 },
                    { "04224af0-784e-4bb8-9c9c-32a8b89a3eec", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(144), "Desc 37", null, null, "Cpp", "Title 37", 0, 0 },
                    { "05eff5cf-b2ac-4df5-8b35-9bfbc7e5237a", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(81), "Desc 30", null, null, "Cpp", "Title 30", 0, 0 },
                    { "0d7a72e3-a0a5-4a8d-909f-9ded86bb8c6d", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(563), "Desc 96", null, null, "Cpp", "Title 96", 0, 0 },
                    { "0d86bf31-3663-461e-b54a-b5c1b3afb633", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(644), "Desc 109", null, null, "Cpp", "Title 109", 0, 0 },
                    { "0dfbbfef-192c-494c-95b9-0d24220c8397", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(400), "Desc 75", null, null, "Cpp", "Title 75", 0, 0 },
                    { "0e4df585-63d9-4bfe-b4b2-02f86463a97c", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(738), "Desc 121", null, null, "Cpp", "Title 121", 0, 0 },
                    { "0eee59c8-5dcb-46d5-a976-170e6b56ac08", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(731), "Desc 120", null, null, "Cpp", "Title 120", 0, 0 },
                    { "19b5966f-1010-4c42-8888-8a761e035f9d", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(707), "Desc 116", null, null, "Cpp", "Title 116", 0, 0 },
                    { "1acb8044-1b5c-492f-b798-949e8aa6fe35", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(106), "Desc 34", null, null, "Cpp", "Title 34", 0, 0 },
                    { "1c50ec4d-a824-470d-ab9e-149f8afe2d07", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(695), "Desc 114", null, null, "Cpp", "Title 114", 0, 0 },
                    { "1f50013d-78e8-4fdc-961a-305a09e4ccd2", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9896), "Desc 5", null, null, "Cpp", "Title 5", 0, 0 },
                    { "232285ab-2a55-4ff9-afdb-4634264a993e", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(100), "Desc 33", null, null, "Cpp", "Title 33", 0, 0 },
                    { "27962453-d280-4acd-93d7-7b767f9e4b47", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(51), "Desc 25", null, null, "Cpp", "Title 25", 0, 0 },
                    { "28b2e60a-1cff-4176-8604-5385a1fe2f47", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(423), "Desc 79", null, null, "Cpp", "Title 79", 0, 0 },
                    { "2b323625-98b3-490c-a3d1-b1591041c657", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(138), "Desc 36", null, null, "Cpp", "Title 36", 0, 0 },
                    { "2cc2c558-34af-4a11-9133-d8786aabbce3", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(656), "Desc 111", null, null, "Cpp", "Title 111", 0, 0 },
                    { "2fd8e6d2-e97c-4fdb-a555-bb245a1d90a8", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(507), "Desc 87", null, null, "Cpp", "Title 87", 0, 0 },
                    { "32106535-f3d6-4904-9ff7-d1a3c9c6b266", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(534), "Desc 91", null, null, "Cpp", "Title 91", 0, 0 },
                    { "361f2159-309a-4fec-b389-0b250de327c5", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(150), "Desc 38", null, null, "Cpp", "Title 38", 0, 0 },
                    { "3c07d023-da32-4216-aab5-4236a56ad817", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(601), "Desc 102", null, null, "Cpp", "Title 102", 0, 0 },
                    { "3c408f9d-4db6-4f8e-9aa2-c0118805f0ee", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(220), "Desc 49", null, null, "Cpp", "Title 49", 0, 0 },
                    { "3d7ad1c1-9481-4ea2-b707-044f06d6b591", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9870), "Desc 1", null, null, "Cpp", "Title 1", 0, 0 },
                    { "3ec290cc-18dc-43bb-9be3-0757e21f8715", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(551), "Desc 94", null, null, "Cpp", "Title 94", 0, 0 },
                    { "3ef0639f-2d5c-4d99-bf02-2e1330f3530b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(662), "Desc 112", null, null, "Cpp", "Title 112", 0, 0 },
                    { "3f5bfb71-ba90-49e0-84c0-742743409bf4", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9923), "Desc 9", null, null, "Cpp", "Title 9", 0, 0 },
                    { "40f2d5db-35db-484f-a60b-101c34a43d17", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(522), "Desc 89", null, null, "Cpp", "Title 89", 0, 0 },
                    { "47947215-818c-4333-a4dc-49c4e424d99e", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9884), "Desc 3", null, null, "Cpp", "Title 3", 0, 0 },
                    { "4d180de4-92ed-4376-b6b5-d24e5c80868f", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9930), "Desc 10", null, null, "Cpp", "Title 10", 0, 0 },
                    { "4df51eec-fd03-4a88-968b-6512bd5da27e", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(650), "Desc 110", null, null, "Cpp", "Title 110", 0, 0 },
                    { "528b14cf-07be-46ad-a861-389ec4009791", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9994), "Desc 16", null, null, "Cpp", "Title 16", 0, 0 },
                    { "556e6e96-102f-475e-a6d7-e590392a063a", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(774), "Desc 127", null, null, "Cpp", "Title 127", 0, 0 },
                    { "55e876eb-fa51-414a-a5bb-c10ac30590b4", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(583), "Desc 99", null, null, "Cpp", "Title 99", 0, 0 },
                    { "56e64fc2-2274-4bf3-9479-0030d0c369ad", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(324), "Desc 63", null, null, "Cpp", "Title 63", 0, 0 },
                    { "57d2872c-a6bf-487e-a291-7f686390e190", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(387), "Desc 73", null, null, "Cpp", "Title 73", 0, 0 },
                    { "59cde79e-62a5-473f-83b6-3ff36d7ac57e", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(780), "Desc 128", null, null, "Cpp", "Title 128", 0, 0 },
                    { "5b0862e5-78fb-4b55-820c-97a9eed8bf62", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(206), "Desc 47", null, null, "Cpp", "Title 47", 0, 0 },
                    { "5d98073a-f799-4053-8372-55548bd2dbd4", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(750), "Desc 123", null, null, "Cpp", "Title 123", 0, 0 },
                    { "5de2b66b-910e-451c-8ad8-de3cae0321c6", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(788), "Desc 129", null, null, "Cpp", "Title 129", 0, 0 },
                    { "60752614-093a-4ec4-8414-a8dcb3ab4278", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(589), "Desc 100", null, null, "Cpp", "Title 100", 0, 0 },
                    { "60ce1051-27c0-483a-9a01-b0896a240b81", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(20), "Desc 20", null, null, "Cpp", "Title 20", 0, 0 },
                    { "62242898-6ab0-4136-90d9-f52f9342d16b", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9909), "Desc 7", null, null, "Cpp", "Title 7", 0, 0 },
                    { "6af6148d-b10a-4575-92a8-ea3996dd43bb", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(261), "Desc 56", null, null, "Cpp", "Title 56", 0, 0 },
                    { "7210a76e-ac1d-43cd-9147-c05e0fe453dc", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(281), "Desc 59", null, null, "Cpp", "Title 59", 0, 0 },
                    { "738607a1-40fa-4aa7-a8e5-524b0684acfb", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9982), "Desc 14", null, null, "Cpp", "Title 14", 0, 0 },
                    { "745a05e5-5e83-4945-9eee-1d3ed83901c7", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(231), "Desc 51", null, null, "Cpp", "Title 51", 0, 0 },
                    { "74d8f3fa-0bcb-4d0c-b4d4-c66fb9b3fde3", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(292), "Desc 61", null, null, "Cpp", "Title 61", 0, 0 },
                    { "75af384b-9eba-435f-806e-17e6e36d76d0", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(689), "Desc 113", null, null, "Cpp", "Title 113", 0, 0 },
                    { "76c18c23-eda5-4fa5-9d7f-69807a68586a", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(557), "Desc 95", null, null, "Cpp", "Title 95", 0, 0 },
                    { "77540020-f545-4ccf-9889-d404196c01e2", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(87), "Desc 31", null, null, "Cpp", "Title 31", 0, 0 },
                    { "79eea990-2178-42c0-ac88-76d4820b3510", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(528), "Desc 90", null, null, "Cpp", "Title 90", 0, 0 },
                    { "7e5148a8-60fc-4787-83ff-64bda199b1b7", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(318), "Desc 62", null, null, "Cpp", "Title 62", 0, 0 },
                    { "7ebf83c2-d525-4ead-b4fc-1291eac46dad", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(112), "Desc 35", null, null, "Cpp", "Title 35", 0, 0 },
                    { "837e2de9-f91e-4ec8-a210-dd49bb023e78", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(380), "Desc 72", null, null, "Cpp", "Title 72", 0, 0 },
                    { "850cc054-af0b-4645-8b92-aa538eff8f08", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(26), "Desc 21", null, null, "Cpp", "Title 21", 0, 0 },
                    { "873ffc1b-e60b-4516-917a-c04388c6b8fd", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9970), "Desc 12", null, null, "Cpp", "Title 12", 0, 0 },
                    { "8c8b2a1b-7db3-4d6a-b58d-9f3a484d1d44", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(719), "Desc 118", null, null, "Cpp", "Title 118", 0, 0 },
                    { "9078f414-329b-467a-b239-2bd796957285", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(460), "Desc 85", null, null, "Cpp", "Title 85", 0, 0 },
                    { "921bfdb2-36af-45c1-af9e-4dbbf7a4bbd6", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(243), "Desc 53", null, null, "Cpp", "Title 53", 0, 0 },
                    { "922c7247-0420-4a10-9947-4e60ef125d1e", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(2), "Desc 17", null, null, "Cpp", "Title 17", 0, 0 },
                    { "92cde209-23be-4804-8dde-aefd471d2185", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(69), "Desc 28", null, null, "Cpp", "Title 28", 0, 0 },
                    { "93ce7be8-0372-4486-be00-9a457cba3091", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9976), "Desc 13", null, null, "Cpp", "Title 13", 0, 0 },
                    { "950aa8d8-f126-4aaa-9de6-8eedd251a983", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(613), "Desc 104", null, null, "Cpp", "Title 104", 0, 0 },
                    { "95e402d9-a2c5-4f3e-b0a2-9d835fd5fae4", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(63), "Desc 27", null, null, "Cpp", "Title 27", 0, 0 },
                    { "961f5915-706e-40c7-9031-d33229e3f599", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(286), "Desc 60", null, null, "Cpp", "Title 60", 0, 0 },
                    { "97b18269-8a6a-430e-808e-9a669e1cd8d8", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(162), "Desc 40", null, null, "Cpp", "Title 40", 0, 0 },
                    { "97de5ad0-a283-487c-a8b9-4d413492455a", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(356), "Desc 68", null, null, "Cpp", "Title 68", 0, 0 },
                    { "9827206a-5428-429b-8f39-79b5b6ddce78", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(545), "Desc 93", null, null, "Cpp", "Title 93", 0, 0 },
                    { "991de8c9-de78-4e16-9cd9-c8eafc230c31", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(762), "Desc 125", null, null, "Cpp", "Title 125", 0, 0 },
                    { "9a22389f-b38f-4252-8926-888660c0594c", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(632), "Desc 107", null, null, "Cpp", "Title 107", 0, 0 },
                    { "9ae79647-eb01-4d53-9161-acf351c16eb8", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(75), "Desc 29", null, null, "Cpp", "Title 29", 0, 0 },
                    { "9dd9fc5a-ddb0-4776-94ea-19032b696968", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(32), "Desc 22", null, null, "Cpp", "Title 22", 0, 0 },
                    { "a1465285-dde9-48b3-b45e-6035627e3a37", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(540), "Desc 92", null, null, "Cpp", "Title 92", 0, 0 },
                    { "a2073149-2e5e-4975-8ab0-a4dbf911fef7", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(188), "Desc 44", null, null, "Cpp", "Title 44", 0, 0 },
                    { "a4193c65-2d82-4e56-8f2b-c1879503679b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(170), "Desc 41", null, null, "Cpp", "Title 41", 0, 0 },
                    { "a4f73457-1683-4d20-857a-fe444d35ce3b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(274), "Desc 58", null, null, "Cpp", "Title 58", 0, 0 },
                    { "a8cd41a2-fc72-4a4c-8948-aca0bcbac937", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(768), "Desc 126", null, null, "Cpp", "Title 126", 0, 0 },
                    { "a948b42f-3346-40ed-b32e-528f64dbfb61", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(38), "Desc 23", null, null, "Cpp", "Title 23", 0, 0 },
                    { "ac0d2636-3e0c-432a-b6ce-a89658f415f2", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(455), "Desc 84", null, null, "Cpp", "Title 84", 0, 0 },
                    { "ae7eda05-f452-4732-bb21-5f72f0210b95", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(595), "Desc 101", null, null, "Cpp", "Title 101", 0, 0 },
                    { "afc32103-1e8e-44e0-86bc-071600a2b550", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(344), "Desc 66", null, null, "Cpp", "Title 66", 0, 0 },
                    { "b03f7031-2489-40ec-bfca-e1b8e7039cb7", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(626), "Desc 106", null, null, "Cpp", "Title 106", 0, 0 },
                    { "b0eabbfb-9bcf-46a3-a65e-9b0aebedb220", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(394), "Desc 74", null, null, "Cpp", "Title 74", 0, 0 },
                    { "b13d1d0b-9743-4bea-871e-b740a8a31dc8", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(437), "Desc 81", null, null, "Cpp", "Title 81", 0, 0 },
                    { "b15425e6-5fbc-4e2e-b487-41edc0f9c84c", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(156), "Desc 39", null, null, "Cpp", "Title 39", 0, 0 },
                    { "b2f01ff2-9cc7-44ea-bd45-8b8b568b82cb", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(374), "Desc 71", null, null, "Cpp", "Title 71", 0, 0 },
                    { "b3509e61-7df1-4f00-803e-9bd0c3baac4b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(330), "Desc 64", null, null, "Cpp", "Title 64", 0, 0 },
                    { "b67186ce-31b2-4bc9-b328-ee64f283d70b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(92), "Desc 32", null, null, "Cpp", "Title 32", 0, 0 },
                    { "b85d54d2-2a21-459a-9f99-c9fa9bf8d87f", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9774), "Desc 0", null, null, "Cpp", "Title 0", 0, 0 },
                    { "b94900e4-5bc6-4709-b6b8-dbf6c0999b59", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(607), "Desc 103", null, null, "Cpp", "Title 103", 0, 0 },
                    { "b9f669e3-0967-4943-8207-3a03c7a47bbd", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9988), "Desc 15", null, null, "Cpp", "Title 15", 0, 0 },
                    { "bc08a35e-15e3-4b20-85a4-5302878f87a5", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(237), "Desc 52", null, null, "Cpp", "Title 52", 0, 0 },
                    { "bcbe93b3-76c0-4170-9dbd-c451cc22586d", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(417), "Desc 78", null, null, "Cpp", "Title 78", 0, 0 },
                    { "c28759a5-3046-4a94-9cd4-f21df1fd1afd", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(514), "Desc 88", null, null, "Cpp", "Title 88", 0, 0 },
                    { "c2bcc609-b761-413b-8d0e-e678c7d8075d", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(8), "Desc 18", null, null, "Cpp", "Title 18", 0, 0 },
                    { "c2de7103-a6a3-428e-bf66-0d0c27b1caae", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(269), "Desc 57", null, null, "Cpp", "Title 57", 0, 0 },
                    { "c3f14093-baca-415c-8d42-7e6c74eed070", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(350), "Desc 67", null, null, "Cpp", "Title 67", 0, 0 },
                    { "c488fef2-b81a-4b3d-b79c-fa0b6359dbd6", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(725), "Desc 119", null, null, "Cpp", "Title 119", 0, 0 },
                    { "c5b1dbff-6b77-4438-9122-9d425b21931f", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(411), "Desc 77", null, null, "Cpp", "Title 77", 0, 0 },
                    { "c901d1da-caef-4b09-9828-3b4199f56ad6", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9964), "Desc 11", null, null, "Cpp", "Title 11", 0, 0 },
                    { "c919875d-f915-4816-83af-be5aa7be70a6", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(701), "Desc 115", null, null, "Cpp", "Title 115", 0, 0 },
                    { "cda17a83-c1ec-45c1-8283-918b094b57aa", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(466), "Desc 86", null, null, "Cpp", "Title 86", 0, 0 },
                    { "ce1e17ea-1a04-4b88-8fa2-df491d6e0ba5", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(368), "Desc 70", null, null, "Cpp", "Title 70", 0, 0 },
                    { "d1930ed1-09d1-43d2-8f8d-a9659c1a32a4", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(429), "Desc 80", null, null, "Cpp", "Title 80", 0, 0 },
                    { "d295f373-c33c-48e0-aea2-0acb1e72dc0f", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(756), "Desc 124", null, null, "Cpp", "Title 124", 0, 0 },
                    { "d43be53b-fd80-4b4b-8f00-1d6ef06b97bb", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(194), "Desc 45", null, null, "Cpp", "Title 45", 0, 0 },
                    { "d72d7522-b0a4-4a40-abad-b02b2d7cbcda", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9877), "Desc 2", null, null, "Cpp", "Title 2", 0, 0 },
                    { "dc34ad62-596d-47cc-8e8b-b526efd1f3da", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(14), "Desc 19", null, null, "Cpp", "Title 19", 0, 0 },
                    { "dcae6468-c01b-4213-a0ee-f94b2a694afc", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(176), "Desc 42", null, null, "Cpp", "Title 42", 0, 0 },
                    { "de43a098-8080-4e52-a9b6-4cf215536187", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(620), "Desc 105", null, null, "Cpp", "Title 105", 0, 0 },
                    { "dfb91686-9489-495a-b088-47c2a8891b5d", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(200), "Desc 46", null, null, "Cpp", "Title 46", 0, 0 },
                    { "e119790c-a04e-451a-864a-5e7b59628b77", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(713), "Desc 117", null, null, "Cpp", "Title 117", 0, 0 },
                    { "e148417b-b407-4ab8-b77d-46b78aaca50d", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9903), "Desc 6", null, null, "Cpp", "Title 6", 0, 0 },
                    { "e1b1183f-a1c1-4ca7-b114-8340ad029876", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(406), "Desc 76", null, null, "Cpp", "Title 76", 0, 0 },
                    { "e2f00b4d-36da-4ff0-abcf-b66909888d5b", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(362), "Desc 69", null, null, "Cpp", "Title 69", 0, 0 },
                    { "e44b0935-3176-478d-9f01-3fb77de25dd3", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(182), "Desc 43", null, null, "Cpp", "Title 43", 0, 0 },
                    { "e88f4f7c-3150-4719-9214-f65d239d052f", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(745), "Desc 122", null, null, "Cpp", "Title 122", 0, 0 },
                    { "eb5e070d-dd01-4356-8942-7cfc9716d05b", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9890), "Desc 4", null, null, "Cpp", "Title 4", 0, 0 },
                    { "ebcc4014-7785-48a7-b44b-18613ee7bf7c", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(57), "Desc 26", null, null, "Cpp", "Title 26", 0, 0 },
                    { "ee08d9f0-6daf-4519-81f5-ac5941621ba2", new DateTime(2023, 5, 9, 23, 58, 41, 366, DateTimeKind.Local).AddTicks(9915), "Desc 8", null, null, "Cpp", "Title 8", 0, 0 },
                    { "f06af473-b1e8-4b84-81e7-35be39948972", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(571), "Desc 97", null, null, "Cpp", "Title 97", 0, 0 },
                    { "f14148d0-7425-4b5c-abde-86916d6404d1", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(449), "Desc 83", null, null, "Cpp", "Title 83", 0, 0 },
                    { "f3b6e116-b82b-47c8-bae4-04d137b3ab70", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(226), "Desc 50", null, null, "Cpp", "Title 50", 0, 0 },
                    { "f81ff09c-5e0c-4613-8df0-eef7c1fae2f8", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(638), "Desc 108", null, null, "Cpp", "Title 108", 0, 0 },
                    { "f857d9d5-b613-4707-853c-fa97e9ab2ab0", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(44), "Desc 24", null, null, "Cpp", "Title 24", 0, 0 },
                    { "fa4408ca-3f03-4a70-bf30-26e8c6d6c7fc", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(338), "Desc 65", null, null, "Cpp", "Title 65", 0, 0 },
                    { "fa87af0f-2d7f-4e4a-b423-b8928a6af132", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(443), "Desc 82", null, null, "Cpp", "Title 82", 0, 0 },
                    { "fbbc291b-563c-4587-84fa-cee24666e8cc", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(249), "Desc 54", null, null, "Cpp", "Title 54", 0, 0 },
                    { "fcf6e5dd-99a4-4055-a303-cd0d39f31b4e", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(577), "Desc 98", null, null, "Cpp", "Title 98", 0, 0 },
                    { "fe1eee9f-b4c8-48a7-9055-ccce71cde1cc", new DateTime(2023, 5, 9, 23, 58, 41, 367, DateTimeKind.Local).AddTicks(212), "Desc 48", null, null, "Cpp", "Title 48", 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "015f73e7-32b1-4754-ba45-8f7f5bd52d34");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "04224af0-784e-4bb8-9c9c-32a8b89a3eec");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "05eff5cf-b2ac-4df5-8b35-9bfbc7e5237a");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "0d7a72e3-a0a5-4a8d-909f-9ded86bb8c6d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "0d86bf31-3663-461e-b54a-b5c1b3afb633");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "0dfbbfef-192c-494c-95b9-0d24220c8397");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "0e4df585-63d9-4bfe-b4b2-02f86463a97c");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "0eee59c8-5dcb-46d5-a976-170e6b56ac08");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "19b5966f-1010-4c42-8888-8a761e035f9d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "1acb8044-1b5c-492f-b798-949e8aa6fe35");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "1c50ec4d-a824-470d-ab9e-149f8afe2d07");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "1f50013d-78e8-4fdc-961a-305a09e4ccd2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "232285ab-2a55-4ff9-afdb-4634264a993e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "27962453-d280-4acd-93d7-7b767f9e4b47");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "28b2e60a-1cff-4176-8604-5385a1fe2f47");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "2b323625-98b3-490c-a3d1-b1591041c657");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "2cc2c558-34af-4a11-9133-d8786aabbce3");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "2fd8e6d2-e97c-4fdb-a555-bb245a1d90a8");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "32106535-f3d6-4904-9ff7-d1a3c9c6b266");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "361f2159-309a-4fec-b389-0b250de327c5");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3c07d023-da32-4216-aab5-4236a56ad817");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3c408f9d-4db6-4f8e-9aa2-c0118805f0ee");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3d7ad1c1-9481-4ea2-b707-044f06d6b591");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3ec290cc-18dc-43bb-9be3-0757e21f8715");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3ef0639f-2d5c-4d99-bf02-2e1330f3530b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "3f5bfb71-ba90-49e0-84c0-742743409bf4");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "40f2d5db-35db-484f-a60b-101c34a43d17");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "47947215-818c-4333-a4dc-49c4e424d99e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "4d180de4-92ed-4376-b6b5-d24e5c80868f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "4df51eec-fd03-4a88-968b-6512bd5da27e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "528b14cf-07be-46ad-a861-389ec4009791");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "556e6e96-102f-475e-a6d7-e590392a063a");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "55e876eb-fa51-414a-a5bb-c10ac30590b4");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "56e64fc2-2274-4bf3-9479-0030d0c369ad");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "57d2872c-a6bf-487e-a291-7f686390e190");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "59cde79e-62a5-473f-83b6-3ff36d7ac57e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5b0862e5-78fb-4b55-820c-97a9eed8bf62");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5d98073a-f799-4053-8372-55548bd2dbd4");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "5de2b66b-910e-451c-8ad8-de3cae0321c6");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "60752614-093a-4ec4-8414-a8dcb3ab4278");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "60ce1051-27c0-483a-9a01-b0896a240b81");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "62242898-6ab0-4136-90d9-f52f9342d16b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "6af6148d-b10a-4575-92a8-ea3996dd43bb");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "7210a76e-ac1d-43cd-9147-c05e0fe453dc");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "738607a1-40fa-4aa7-a8e5-524b0684acfb");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "745a05e5-5e83-4945-9eee-1d3ed83901c7");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "74d8f3fa-0bcb-4d0c-b4d4-c66fb9b3fde3");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "75af384b-9eba-435f-806e-17e6e36d76d0");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "76c18c23-eda5-4fa5-9d7f-69807a68586a");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "77540020-f545-4ccf-9889-d404196c01e2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "79eea990-2178-42c0-ac88-76d4820b3510");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "7e5148a8-60fc-4787-83ff-64bda199b1b7");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "7ebf83c2-d525-4ead-b4fc-1291eac46dad");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "837e2de9-f91e-4ec8-a210-dd49bb023e78");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "850cc054-af0b-4645-8b92-aa538eff8f08");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "873ffc1b-e60b-4516-917a-c04388c6b8fd");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "8c8b2a1b-7db3-4d6a-b58d-9f3a484d1d44");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9078f414-329b-467a-b239-2bd796957285");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "921bfdb2-36af-45c1-af9e-4dbbf7a4bbd6");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "922c7247-0420-4a10-9947-4e60ef125d1e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "92cde209-23be-4804-8dde-aefd471d2185");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "93ce7be8-0372-4486-be00-9a457cba3091");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "950aa8d8-f126-4aaa-9de6-8eedd251a983");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "95e402d9-a2c5-4f3e-b0a2-9d835fd5fae4");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "961f5915-706e-40c7-9031-d33229e3f599");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "97b18269-8a6a-430e-808e-9a669e1cd8d8");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "97de5ad0-a283-487c-a8b9-4d413492455a");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9827206a-5428-429b-8f39-79b5b6ddce78");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "991de8c9-de78-4e16-9cd9-c8eafc230c31");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9a22389f-b38f-4252-8926-888660c0594c");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9ae79647-eb01-4d53-9161-acf351c16eb8");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "9dd9fc5a-ddb0-4776-94ea-19032b696968");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a1465285-dde9-48b3-b45e-6035627e3a37");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a2073149-2e5e-4975-8ab0-a4dbf911fef7");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a4193c65-2d82-4e56-8f2b-c1879503679b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a4f73457-1683-4d20-857a-fe444d35ce3b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a8cd41a2-fc72-4a4c-8948-aca0bcbac937");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "a948b42f-3346-40ed-b32e-528f64dbfb61");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ac0d2636-3e0c-432a-b6ce-a89658f415f2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ae7eda05-f452-4732-bb21-5f72f0210b95");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "afc32103-1e8e-44e0-86bc-071600a2b550");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b03f7031-2489-40ec-bfca-e1b8e7039cb7");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b0eabbfb-9bcf-46a3-a65e-9b0aebedb220");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b13d1d0b-9743-4bea-871e-b740a8a31dc8");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b15425e6-5fbc-4e2e-b487-41edc0f9c84c");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b2f01ff2-9cc7-44ea-bd45-8b8b568b82cb");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b3509e61-7df1-4f00-803e-9bd0c3baac4b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b67186ce-31b2-4bc9-b328-ee64f283d70b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b85d54d2-2a21-459a-9f99-c9fa9bf8d87f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b94900e4-5bc6-4709-b6b8-dbf6c0999b59");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "b9f669e3-0967-4943-8207-3a03c7a47bbd");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "bc08a35e-15e3-4b20-85a4-5302878f87a5");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "bcbe93b3-76c0-4170-9dbd-c451cc22586d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c28759a5-3046-4a94-9cd4-f21df1fd1afd");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c2bcc609-b761-413b-8d0e-e678c7d8075d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c2de7103-a6a3-428e-bf66-0d0c27b1caae");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c3f14093-baca-415c-8d42-7e6c74eed070");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c488fef2-b81a-4b3d-b79c-fa0b6359dbd6");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c5b1dbff-6b77-4438-9122-9d425b21931f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c901d1da-caef-4b09-9828-3b4199f56ad6");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "c919875d-f915-4816-83af-be5aa7be70a6");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "cda17a83-c1ec-45c1-8283-918b094b57aa");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ce1e17ea-1a04-4b88-8fa2-df491d6e0ba5");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "d1930ed1-09d1-43d2-8f8d-a9659c1a32a4");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "d295f373-c33c-48e0-aea2-0acb1e72dc0f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "d43be53b-fd80-4b4b-8f00-1d6ef06b97bb");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "d72d7522-b0a4-4a40-abad-b02b2d7cbcda");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "dc34ad62-596d-47cc-8e8b-b526efd1f3da");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "dcae6468-c01b-4213-a0ee-f94b2a694afc");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "de43a098-8080-4e52-a9b6-4cf215536187");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "dfb91686-9489-495a-b088-47c2a8891b5d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e119790c-a04e-451a-864a-5e7b59628b77");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e148417b-b407-4ab8-b77d-46b78aaca50d");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e1b1183f-a1c1-4ca7-b114-8340ad029876");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e2f00b4d-36da-4ff0-abcf-b66909888d5b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e44b0935-3176-478d-9f01-3fb77de25dd3");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "e88f4f7c-3150-4719-9214-f65d239d052f");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "eb5e070d-dd01-4356-8942-7cfc9716d05b");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ebcc4014-7785-48a7-b44b-18613ee7bf7c");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "ee08d9f0-6daf-4519-81f5-ac5941621ba2");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f06af473-b1e8-4b84-81e7-35be39948972");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f14148d0-7425-4b5c-abde-86916d6404d1");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f3b6e116-b82b-47c8-bae4-04d137b3ab70");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f81ff09c-5e0c-4613-8df0-eef7c1fae2f8");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "f857d9d5-b613-4707-853c-fa97e9ab2ab0");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "fa4408ca-3f03-4a70-bf30-26e8c6d6c7fc");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "fa87af0f-2d7f-4e4a-b423-b8928a6af132");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "fbbc291b-563c-4587-84fa-cee24666e8cc");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "fcf6e5dd-99a4-4055-a303-cd0d39f31b4e");

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: "fe1eee9f-b4c8-48a7-9055-ccce71cde1cc");
        }
    }
}
