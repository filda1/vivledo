using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using vivledo.device.Models;

namespace vivledo.device.ViewModels
{
    public class CardViewModel:BaseViewModel
    {
        public ObservableCollection<Alert> alert { get; set; }
        public CardViewModel()
        {
            Title = "Alert";
    
          

            alert = new ObservableCollection<Alert>
            {
                  new Alert
                    {
                         Cabecalho = " 1 dia atrás   - FaceBook ",
                         Linhas= "Facebook com Android 7.0 certificado - GSM Arena News " ,
                         Imagem = "person2",
                         Descricao = "Facebook é uma rede social lançada em 4 de fevereiro...........exemplo de texto usado para testar a clonagem do cardview no Xamarin Forms em 2018",
                    },
                     new Alert
                    {
                         Cabecalho = " 9 hrs atrás   - The Indipendendent",
                         Linhas="Game of THrones season 7 : Fans think Catelyn's Stark's Ghost was" ,
                         Descricao = "O Independente é um jornal on-line britânico.[2]...........exemplo de texto usado para testar a clonagem do cardview no Xamarin Forms em 2018",
                          Imagem = "person2",
                    },
                    new Alert
                    {
                        Cabecalho = " 10 hrs atrás  - Power BI Microsoft",
                        Linhas    = "Anunciando a solução Power BI Solution para conectividade Azure Log" ,
                        Descricao = "Microsoft Corporation (/ˈmaɪkrəˌsɒft/,[2][3] abreviada...........exemplo de texto usado para testar a clonagem do cardview no Xamarin Forms em 2018",
                         Imagem = "person2",
                    },
                      new Alert
                    {
                        Cabecalho = " 13 hrs atrás  - SQL Server Management Studio ",
                        Linhas    = "SQL Server é um banco de dados relacional ou SGBD que permite a criação de banco de dados e tabelas em suas aplicações",
                        Descricao = "Google Maps usado para localizar endereços e sua localização",
                         Imagem = "person2",
                    },
                      new Alert
                    {
                        Cabecalho = " 15 hrs atrás - Android Autoridadae",
                        Descricao = "Se você já leu o livro de Julio Verne...........exemplo de texto usado para testar a clonagem do cardview no Xamarin Forms." ,
                        Linhas    = "Definições e escolhas feitas a esmo : 5 coisas que você deve saber sobre o seu celular" ,
                          Imagem = "person2",
                    },
                };

        }
    }
}