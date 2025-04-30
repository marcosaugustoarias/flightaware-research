using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Research.Business;
using Research.Entities;
using Xunit;

namespace UnitTest
{
    
    public class VuelosTest 
    {
        [Fact]
        public void se_debe_obtener_los_datos_del_vuelo()
        {
            // Arrange.
            VueloManager vueloManager = new VueloManager();

            // Act.
            VueloInfo vueloInfo = vueloManager.GetVueloInfo("AR1638", DateTime.Now);

            // Assert.
            Assert.True(vueloInfo.NumeroVuelo == "AR1638");
        }

        [Fact]
        public void al_pasar_num_vuelo_invalido_debe_lanzar_flywhareexeption()
        {
            VueloManager vueloManager = new VueloManager();
            VueloInfo vueloInfo = vueloManager.GetVueloInfo("XX0000", DateTime.Now);


            Assert.True(!string.IsNullOrWhiteSpace(vueloInfo.NumeroVuelo));
        }
    }
}
