using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiKonie.Controllers;
using WebApiKonie.Models;
using Xunit;

namespace TestyKonie
{
   public class KonTest
    {
       
        KonController _konController;
        
        public KonTest()
        {
            DbContextOptions<ZakladyDB> options = new DbContextOptionsBuilder<ZakladyDB>().UseInMemoryDatabase(databaseName: "baza").Options;
            ZakladyDB zaklady = new ZakladyDB();
            _konController = new KonController(zaklady);
        }

        [Fact]
        public void DodanieNowegoKonia()
        {
            //Arrange
            KonDTO kon = new KonDTO() { Kondycja = 95, Kraj = "Polska", Nazwa = "Piorun", Predkosc = 80, Wiek = 3 };

            //Act 
            var okResult = _konController.add(kon).Result as OkObjectResult;

            //Assert
            Assert.IsType<bool>(okResult.Value);
            Assert.Equal(true, okResult.Value);
        }

        [Fact]
        public void PobranieKoniaoDanymId()
        {
            //Arange
            string nazwa = "Elf";

            //Act
            var okResult = _konController.getById(7).Result as OkObjectResult;

            //Assert
            Assert.IsType<KonDTO>(okResult.Value);
            Assert.Equal(nazwa, (okResult.Value as KonDTO).Nazwa);

        }

        [Fact]
        public void PobierzWszystkieKonie()
        {
            //Act
            var okResult = _konController.getAll().Result as OkObjectResult;

            //Assert
            var items = Assert.IsType<List<KonDTO>>(okResult.Value);
            Assert.Equal(15, items.Count);
        }



    }
}
