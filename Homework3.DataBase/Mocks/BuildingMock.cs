using Homework2.DataBase.Domain;
using System.Collections.Generic;

namespace Homework2.DataBase.Mocks
{
    /// <summary>
    /// Mock для коллекции "Здание".
    /// </summary>
   public class BuildingMock
    {
        /// <summary>
        /// Получение коллекции сущности "Здание".
        /// </summary>
        /// <returns>Коллекция сущностей "Здание".</returns>
        public static IEnumerable<Building> GetBuilding()
        {
            return new List<Building> {
                new Building {Id = 1, Street ="Димитрова", Number=88, Purpose ="Жилое", NumberOfFloors=9, Square=1000, CadastralNumber="23:1234567:34:65"},
                new Building {Id = 2, Street ="Земеца", Number=44, Purpose ="Производственное", NumberOfFloors=1, Square=500, CadastralNumber="23:1457567:34:65"},
                new Building {Id = 3, Street ="Волжская", Number=34, Purpose ="Гараж", NumberOfFloors=1, Square=150, CadastralNumber="23:1234247:34:65"},
                new Building {Id = 3, Street ="Московское шоссе", Number=2, Purpose ="Офисы", NumberOfFloors=25, Square=2000, CadastralNumber="56:1234567:34:89"}
            };
        }

    }
}
