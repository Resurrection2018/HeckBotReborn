﻿// <auto-generated />
using System;
using HeckBot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeckBot.Migrations
{
    [DbContext(typeof(HeckBotContext))]
    partial class HeckBotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("HeckBot.Models.ShieldDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("ChannelId");

                    b.Property<DateTime>("NextNotificationTime");

                    b.Property<DateTime>("ShieldEndTime");

                    b.Property<ulong>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ShieldTimers");
                });
#pragma warning restore 612, 618
        }
    }
}
