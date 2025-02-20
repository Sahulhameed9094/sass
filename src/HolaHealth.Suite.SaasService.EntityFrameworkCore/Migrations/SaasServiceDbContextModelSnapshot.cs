﻿// <auto-generated />
using System;
using HolaHealth.Suite.SaasService.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace HolaHealth.Suite.SaasService.Migrations
{
    [DbContext(typeof(SaasServiceDbContext))]
    partial class SaasServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.PostgreSql)
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Volo.Payment.Plans.GatewayPlan", b =>
                {
                    b.Property<Guid>("PlanId")
                        .HasColumnType("uuid");

                    b.Property<string>("Gateway")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.HasKey("PlanId", "Gateway");

                    b.ToTable("PayGatewayPlans", (string)null);
                });

            modelBuilder.Entity("Volo.Payment.Plans.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("PayPlans", (string)null);
                });

            modelBuilder.Entity("Volo.Payment.Requests.PaymentRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Currency")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EmailSendDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalSubscriptionId")
                        .HasColumnType("text");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("FailReason")
                        .HasColumnType("text");

                    b.Property<string>("Gateway")
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.ToTable("PayPaymentRequests", (string)null);
                });

            modelBuilder.Entity("Volo.Payment.Requests.PaymentRequestProduct", b =>
                {
                    b.Property<Guid>("PaymentRequestId")
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("ExtraProperties")
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("PaymentType")
                        .HasColumnType("smallint");

                    b.Property<Guid?>("PlanId")
                        .HasColumnType("uuid");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("PaymentRequestId", "Code");

                    b.ToTable("PayPaymentRequestProducts", (string)null);
                });

            modelBuilder.Entity("Volo.Saas.Editions.Edition", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("DisplayName");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("integer");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid?>("PlanId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DisplayName");

                    b.ToTable("SaasEditions", (string)null);
                });

            modelBuilder.Entity("Volo.Saas.Tenants.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("ActivationEndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("ActivationState")
                        .HasColumnType("smallint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("uuid")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DeletionTime");

                    b.Property<DateTime?>("EditionEndDateUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("EditionId")
                        .HasColumnType("uuid");

                    b.Property<int>("EntityVersion")
                        .HasColumnType("integer");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("uuid")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("SaasTenants", (string)null);
                });

            modelBuilder.Entity("Volo.Saas.Tenants.TenantConnectionString", b =>
                {
                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("Name");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("Value");

                    b.HasKey("TenantId", "Name");

                    b.ToTable("SaasTenantConnectionStrings", (string)null);
                });

            modelBuilder.Entity("Volo.Payment.Plans.GatewayPlan", b =>
                {
                    b.HasOne("Volo.Payment.Plans.Plan", null)
                        .WithMany("GatewayPlans")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Payment.Requests.PaymentRequestProduct", b =>
                {
                    b.HasOne("Volo.Payment.Requests.PaymentRequest", null)
                        .WithMany("Products")
                        .HasForeignKey("PaymentRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Saas.Tenants.TenantConnectionString", b =>
                {
                    b.HasOne("Volo.Saas.Tenants.Tenant", null)
                        .WithMany("ConnectionStrings")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Volo.Payment.Plans.Plan", b =>
                {
                    b.Navigation("GatewayPlans");
                });

            modelBuilder.Entity("Volo.Payment.Requests.PaymentRequest", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Volo.Saas.Tenants.Tenant", b =>
                {
                    b.Navigation("ConnectionStrings");
                });
#pragma warning restore 612, 618
        }
    }
}
