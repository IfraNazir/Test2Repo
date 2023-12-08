using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Family_tree.Models
{
    public class MyAppContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"DatabaseFamilyTree");
            Directory.CreateDirectory(sqlitePath);
            var fileName = $"{sqlitePath}\\FamilyNameDb.db";
            if(!File.Exists(fileName))
                File.Create(fileName);
            optionBuilder.UseSqlite($"Data Source={fileName}");
        }
        public DbSet<FamilyTitle> FamilyTitles { get; set; }
 
        public DbSet<FamilyTree> FamilyTrees { get; set; }
        public DbSet<FamilyMember> FamilyMembers { get; set; }

    }
}
