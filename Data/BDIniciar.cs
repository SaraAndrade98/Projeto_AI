using Projeto_AI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_AI.Data
{
    public class BDIniciar
    {
        public static void Iniciar(Projeto_AIContext context)
        {
            
            context.Database.EnsureCreated();
            //Verificar se existem registos
            if (context.DispositivoEletronico.Any())
            {
                return;
            }

            //Criar Categorias
            var cat = new DispositivoEletronico[]
            {
                //Nome - O que for (tenta meter a o nome e as gigas se tiver o resto caga
                //Marca final - apple, Huawei, Xiaomi, Samsung, 
                //Estado_Final - muito mau, mau, medio, bom, muito bom

                new DispositivoEletronico{Nome = "iPhone 6s 32 GB", Ano=2012, Marca_Final="Apple", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=true, Preco= 270.0} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Smartphone Xiaomi A24 GB/64GB", Ano=2014, Marca_Final="Xiaomi", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 109.0} ,
                new DispositivoEletronico{Nome = "iPhone 7 32GB", Ano=2016, Marca_Final="Apple", Estado_Final="Medio", Acessorios=false, IncidentesAquaticos=false, Preco= 500} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy S5 64GB SM-G950", Ano=2010, Marca_Final="Samsung", Estado_Final="Muito Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 60.00} ,
                new DispositivoEletronico{Nome = "iPhone 8 Plus 64GB", Ano=2017, Marca_Final="Apple", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 570.60} ,
                new DispositivoEletronico{Nome = "Nokia 3310 ", Ano=2000, Marca_Final="Nokia", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 29.99} ,
                new DispositivoEletronico{Nome = "ZTC C205 ", Ano=2014, Marca_Final="ZTC", Estado_Final="Medio", Acessorios=true, IncidentesAquaticos=false, Preco= 14.99} ,
                new DispositivoEletronico{Nome = "Meizu M6 32GB", Ano=2017, Marca_Final="Meizu", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 49.99} ,
                new DispositivoEletronico{Nome = "MEO S21 8 GB ", Ano=2018, Marca_Final="MEO", Estado_Final="Muito Bom", Acessorios=false, IncidentesAquaticos=false, Preco= 19.99} ,
                new DispositivoEletronico{Nome = "Alcatel 1X 16GB ", Ano=2018, Marca_Final="Alcatel", Estado_Final="Muito Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 19.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy S8 64 GB", Ano=2017, Marca_Final="Samsung", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 549.90} ,
                new DispositivoEletronico{Nome = "Huawei Y7 2018 16GB", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 119.99} ,
                new DispositivoEletronico{Nome = "Huawei P20 Lite ", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 329.99} ,
                new DispositivoEletronico{Nome = "Huawei Mate 10 Lite ", Ano=2017, Marca_Final="Huawei", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 179.99} ,
                new DispositivoEletronico{Nome = "ASUS Zenfone 4 Selfie Pro ", Ano=2017, Marca_Final="ASUS", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=true, Preco= 99.99} ,
                new DispositivoEletronico{Nome = "Apple Iphone 6s", Ano=2015, Marca_Final="Apple", Estado_Final="Muito Mau", Acessorios=false, IncidentesAquaticos=false, Preco= 59.99} ,
                new DispositivoEletronico{Nome = "Huawei P Smart 32GB", Ano=2018, Marca_Final="Huawei", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 149.99},
                new DispositivoEletronico{Nome = "Samsung Galaxy J3 2017 16GB", Ano=2017, Marca_Final="Samsung", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco=119.99} ,
                new DispositivoEletronico{Nome = "Huawei Y6 2018 16GB ", Ano=2018, Marca_Final="Huawei", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 89.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy J6 32 GB ", Ano=2018, Marca_Final="Samsung", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 89.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy A7 64GB ", Ano=2017, Marca_Final="Samsung", Estado_Final="Muito Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 99.99} ,
                new DispositivoEletronico{Nome = "Huawei Y5 2018 16GB ", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=false, IncidentesAquaticos=false, Preco= 39.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy S9 64GB ", Ano=2018, Marca_Final="Samsung", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 699.99} ,
                new DispositivoEletronico{Nome = "Alcatel 20.51D", Ano=2016, Marca_Final="Alcatel", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 19.90},
                new DispositivoEletronico{Nome = "Apple iphone X ", Ano=2018, Marca_Final="Apple", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 649.99} ,
                new DispositivoEletronico{Nome = "Alcatel 5V ", Ano=2018, Marca_Final="Alcatel", Estado_Final="Muito Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 49.99} ,
                new DispositivoEletronico{Nome = "XIAOMI Redmi 6A 16GB", Ano=2018, Marca_Final="XIAOMI", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=true, Preco= 39.90} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy A6 32GB ", Ano=2018, Marca_Final="Samsung", Estado_Final="Medio", Acessorios=true, IncidentesAquaticos=false, Preco= 139.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy A8 2018 32GB ", Ano=2018, Marca_Final="Samsung", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 269.99} ,
                //30
                new DispositivoEletronico{Nome = "Samsung Galaxy S7 Edge ", Ano=2016, Marca_Final="Samsung", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 349.99} ,
                new DispositivoEletronico{Nome = "LG P500 ", Ano=2010, Marca_Final="LG", Estado_Final="Médio", Acessorios=true, IncidentesAquaticos=false, Preco= 29.99} ,
                new DispositivoEletronico{Nome = "Xiaomi Mi A2 64GB", Ano=2018, Marca_Final="Xiaomi", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 234.99} ,
                new DispositivoEletronico{Nome = "Wiko raibow", Ano=2014, Marca_Final="Wiko", Estado_Final="Muito Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 9.99} ,
                new DispositivoEletronico{Nome = "Huawei Mate S 64GB ", Ano=2015, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 239.90} ,
                new DispositivoEletronico{Nome = "Apple iPhone SE 16GB", Ano=2016, Marca_Final="Apple", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 209.99} ,
                new DispositivoEletronico{Nome = "Blackberry 9700 ", Ano=2010, Marca_Final="Vodafone", Estado_Final="Médio", Acessorios=true, IncidentesAquaticos=false, Preco= 14.99} ,
                new DispositivoEletronico{Nome = "Nokia 8310", Ano=2002, Marca_Final="Nokia", Estado_Final="Muito Bom", Acessorios=false, IncidentesAquaticos=false, Preco= 4.99} ,
                new DispositivoEletronico{Nome = "Huawei G6600", Ano=2014, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 29.99} ,
                new DispositivoEletronico{Nome = "Sony Ericsson S312 ", Ano=2009, Marca_Final="Sony", Estado_Final="Medio", Acessorios=true, IncidentesAquaticos=false, Preco= 19.99} ,
                new DispositivoEletronico{Nome = "Apple iPhone 5s  ", Ano=2013, Marca_Final="Apple", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco= 99.90} ,
                new DispositivoEletronico{Nome = "Apple iPhone 7 Plus 128GB ", Ano=2016, Marca_Final="Apple", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 499.99} ,
                new DispositivoEletronico{Nome = "Asus Zenfone 5 A501CG", Ano=2015, Marca_Final="Asus", Estado_Final="Muito Bom", Acessorios=false, IncidentesAquaticos=false, Preco= 39.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy j7 2017 ", Ano=2017, Marca_Final="Samsung", Estado_Final=" Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 170.99} ,
                new DispositivoEletronico{Nome = "MEO Smart A88 ", Ano=2016, Marca_Final="MEO", Estado_Final="Muito Mau", Acessorios=false, IncidentesAquaticos=false, Preco= 4.99} ,
                new DispositivoEletronico{Nome = "Nokia 6700 Slide ", Ano=2010, Marca_Final="Nokia", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 49.99} ,
                new DispositivoEletronico{Nome = "Sony Xperia M4 AQUA ", Ano=2015, Marca_Final="Sony", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 69.99} ,
                new DispositivoEletronico{Nome = "Sony Xperia E C1505", Ano=2013, Marca_Final="Sony", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 39.99} ,
                new DispositivoEletronico{Nome = "Wiko Robby", Ano=2017, Marca_Final="Wiko", Estado_Final="Mau", Acessorios=true, IncidentesAquaticos=false, Preco=39.99} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy J4 Plus ", Ano=2018, Marca_Final="Samsung", Estado_Final="Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 179} ,
                //50
                new DispositivoEletronico{Nome = "Samsung Galaxy Gt-S6810P", Ano=2013, Marca_Final="Samsung", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 39.90} ,
                new DispositivoEletronico{Nome = "Samsung Galaxy J6 DUOS", Ano=2018, Marca_Final="Samsung", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 169.99} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                new DispositivoEletronico{Nome = "Huawei Mate 20 Pro", Ano=2018, Marca_Final="Huawei", Estado_Final="Muito Bom", Acessorios=true, IncidentesAquaticos=false, Preco= 940.90} ,
                //70
            };

            //Inserir novas categorias na tabela da base de dados
            foreach (var c in cat)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();

        }
    }
}
