using ConversorNumerosRomanosParaArabico;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConversorNumeros.Test
{
    [TestClass]
    public class ConversorNumeroRomanoParaArabicoTest
    {
        private ConversorNumeroRomanoParaArabico conversor;

        public ConversorNumeroRomanoParaArabicoTest()
        {
            conversor = new ConversorNumeroRomanoParaArabico();
        }

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        public void Deve_converter_numeros_romanos_do_1_ao_10(string numero, int resultadoEsperado)
        {
            //cenário - arrange
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("XVI", 16)]
        [DataRow("XVII", 17)]
        [DataRow("XVIII", 18)]
        [DataRow("XIX", 19)]
        [DataRow("XX", 20)]
        public void Deve_converter_numeros_romanos_do_11_ao_20(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XXI", 21)]
        [DataRow("XXII", 22)]
        [DataRow("XXIII", 23)]
        [DataRow("XXIV", 24)]
        [DataRow("XXV", 25)]
        [DataRow("XXVI", 26)]
        [DataRow("XXVII", 27)]
        [DataRow("XXVIII", 28)]
        [DataRow("XXIX", 29)]
        [DataRow("XXX", 30)]
        public void Deve_converter_numeros_romanos_do_21_ao_30(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

              //verificação - assert
               Assert.AreEqual(resultadoEsperado, resultado);
        }  
           
        [TestMethod]
        [DataRow("XXXI", 31)]
        [DataRow("XXXII",  32)]
        [DataRow("XXXIII", 33)]
        [DataRow("XXXIV", 34)]
        [DataRow("XXXV", 35)]
        [DataRow("XXXVI", 36)]
        [DataRow("XXXVII", 37)]
        [DataRow("XXXVIII", 38)]
        [DataRow("XXXIX", 39)]
        [DataRow("XL", 40)]
        public void Deve_converter_numeros_romanos_do_31_ao_40(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("XLI", 41)]
        [DataRow("XLII", 42)]
        [DataRow("XLIII", 43)]
        [DataRow("XLIV", 44)]
        [DataRow("XLV", 45)]
        [DataRow("XLVI", 46)]
        [DataRow("XLVII", 47)]
        [DataRow("XLVIII", 48)]
        [DataRow("XLIX", 49)]
        [DataRow("L", 50)]
        public void Deve_converter_numeros_romanos_do_41_ao_50(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LI", 51)]
        [DataRow("LII", 52)]
        [DataRow("LIII", 53)]
        [DataRow("LIV", 54)]
        [DataRow("LV", 55)]
        [DataRow("LVI", 56)]
        [DataRow("LVII", 57)]
        [DataRow("LVIII", 58)]
        [DataRow("LIX", 59)]
        [DataRow("LX", 60)]
        public void Deve_converter_numeros_romanos_do_51_ao_60(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow("LXI",    61)]
        [DataRow("LXII",   62)]
        [DataRow("LXIII",  63)]
        [DataRow("LXIV",   64)]
        [DataRow("LXV",    65)]
        [DataRow("LXVI",   66)]
        [DataRow("LXVII",  67)]
        [DataRow("LXVIII", 68)]
        [DataRow("LXIX",   69)]
        [DataRow("LXX",    70)]
        public void Deve_converter_numeros_romanos_do_61_ao_70(string numero, int resultadoEsperado)
        {
            string numeroRomano = numero;

            //ação - action 
            var resultado = conversor.Converter(numeroRomano);

            //verificação - assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
