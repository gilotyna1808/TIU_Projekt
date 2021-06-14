﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiKonie.Controllers;
using WebApiKonie.Models;
using WebApiKonie.Services;
using Xunit;

namespace TestyKonie
{
    public class KlientTest
    {
        KlientController _controler;

        public KlientTest()
        {
            DbContextOptions<ZakladyDB> options = new DbContextOptionsBuilder<ZakladyDB>().UseInMemoryDatabase(databaseName: "baza").Options;
            ZakladyDB zaklady = new ZakladyDB();
            _controler = new KlientController(zaklady);
        }

        [Fact]
        public void Pobierz_Wszystkich_Klientow()
        {
            //ACT
            var okResult = _controler.getAll().Result as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<KlientDTO>>(okResult.Value);
            Assert.Equal(3,items.Count);
        }

        [Fact]
        public void Pobierz_uzytkownika_z_id()
        {
            //Arange
            string imie = "Kamil";


            //ACT
            var okResult = _controler.getById(1).Result as OkObjectResult;

            //Assert
            Assert.IsType<KlientDTO>(okResult.Value);
            Assert.Equal(imie, (okResult.Value as KlientDTO).Imie);
        }

        [Fact]
        public void Zmien_Dane_Klienta()
        {
            //Arange
            KlientDTO temp = new KlientDTO() { ID_Klienta = 1, Imie = "Kamil", Nazwisko = "Kamilowski", Email = "aaa", StanKonta = 5000, Wiek = 24 };

            //ACT
            var okResult = _controler.update(temp).Result as OkObjectResult;

            //Assert
            Assert.IsType<bool>(okResult.Value);
            Assert.Equal(true, okResult.Value);
        }
    }
}
