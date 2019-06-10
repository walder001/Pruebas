using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.Entidades;

namespace ProyectoFinal.BLL.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuarios n = new Usuarios();
            n.UsuarioId = 0;
            n.Nombre = "Walder";
            n.Email = "WalderReyes@mail.com";
            n.NivelUsuario = 0;
            n.Usuario = "Walder";
            n.Clave = "12345";
            n.FehaIngreso = DateTime.Now;

            paso = UsuarioBLL.Guardar(n);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            //UsuarioId, Nombres, Email, NivelUsuario, Usuario, Clave, FechaIngreso

           
 
            
            Assert.Fail();
        } 

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}