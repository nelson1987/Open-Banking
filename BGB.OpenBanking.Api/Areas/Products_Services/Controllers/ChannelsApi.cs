using BGB.OpenBanking.Api.Areas.Common.Attributes;
using BGB.OpenBanking.Api.Areas.Products_Services.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace BGB.OpenBanking.Api.Areas.Products_Services.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ChannelsApiController : ControllerBase
    { 
        /// <summary>
        /// Obtém a lista de correspondentes bancários da instituição financeira.
        /// </summary>
        /// <remarks>Método para obter a lista de correspondentes bancários da instituição financeira.</remarks>
        /// <response code="200">Lista de correspondentes bancários obtida com sucesso.</response>
        [HttpGet]
        [Route("/open-banking/channels/v1/banking-agents")]
        [ValidateModelState]
        [SwaggerOperation("GetBankingAgents")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBankingAgentsList), description: "Lista de correspondentes bancários obtida com sucesso.")]
        public virtual IActionResult GetBankingAgents()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBankingAgentsList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"brand\" : {\n      \"name\" : \"Organização A\",\n      \"companies\" : [ {\n        \"name\" : \"Empresa A1\",\n        \"cnpjNumber\" : \"45086338000178\",\n        \"contractors\" : [ {\n          \"name\" : \"Empresa Contratante 1\",\n          \"cnpjNumber\" : \"99558332000137\",\n          \"bankingAgents\" : [ {\n            \"identification\" : {\n              \"corporationName\" : \"Empresa Correspondente A\",\n              \"groupName\" : \"Grupo Master\",\n              \"cnpjNumber\" : \"02345876000299\",\n              \"isUnderestablishment\" : true\n            },\n            \"locations\" : [ {\n              \"postalAddress\" : {\n                \"address\" : \"Av Tasuko Ykeda, 25\",\n                \"districtName\" : \"Centro\",\n                \"townName\" : \"Marília\",\n                \"countrySubDivision\" : \"SP\",\n                \"postCode\" : \"17500001\",\n                \"additionalInfo\" : \"Loja B.\",\n                \"ibgeCode\" : \"3550308\",\n                \"country\" : \"Brasil\",\n                \"countryCode\" : \"BRA\",\n                \"geographicCoordinates\" : {\n                  \"latitude\" : \"-90.8365180\",\n                  \"longitude\" : \"-180.836519\"\n                }\n              },\n              \"phones\" : [ {\n                \"type\" : \"FIXO\",\n                \"countryCallingCode\" : \"55\",\n                \"areaCode\" : \"14\",\n                \"number\" : \"35721199\"\n              }, {\n                \"type\" : \"MOVEL\",\n                \"countryCallingCode\" : \"55\",\n                \"areaCode\" : \"14\",\n                \"number\" : \"997865532\"\n              } ],\n              \"availability\" : {\n                \"standards\" : [ {\n                  \"weekday\" : \"SEGUNDA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"TERCA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUARTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUINTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"SEXTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                } ],\n                \"exception\" : \"Exceto feriados municipais, estaduais e nacionais\",\n                \"isPublicAccessAllowed\" : true\n              }\n            }, {\n              \"postalAddress\" : {\n                \"address\" : \"R Yroshima Takasi, 72\",\n                \"districtName\" : \"Altos da Colina\",\n                \"townName\" : \"Marília\",\n                \"countrySubDivision\" : \"SP\",\n                \"postCode\" : \"17526760\",\n                \"additionalInfo\" : \"Loja 2.\",\n                \"ibgeCode\" : \"3550308\",\n                \"country\" : \"Brasil\",\n                \"countryCode\" : \"BRA\",\n                \"geographicCoordinates\" : {\n                  \"latitude\" : \"-90.8365180\",\n                  \"longitude\" : \"-180.836519\"\n                }\n              },\n              \"phones\" : [ {\n                \"type\" : \"FIXO\",\n                \"countryCallingCode\" : \"55\",\n                \"areaCode\" : \"14\",\n                \"number\" : \"64721199\"\n              } ],\n              \"availability\" : {\n                \"standards\" : [ {\n                  \"weekday\" : \"SEGUNDA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"TERCA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUARTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUINTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"SEXTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                } ],\n                \"exception\" : \"Exceto feriados municipais, estaduais e nacionais\",\n                \"isPublicAccessAllowed\" : true\n              }\n            }, {\n              \"postalAddress\" : {\n                \"address\" : \"Al Nasso Origami, 15, bloco A\",\n                \"districtName\" : \"Centro\",\n                \"townName\" : \"Marília\",\n                \"countrySubDivision\" : \"SP\",\n                \"postCode\" : \"17500001\",\n                \"additionalInfo\" : \"Loja B.\",\n                \"ibgeCode\" : \"3550308\",\n                \"country\" : \"Brasil\",\n                \"countryCode\" : \"BRA\",\n                \"geographicCoordinates\" : {\n                  \"latitude\" : \"-90.8365180\",\n                  \"longitude\" : \"-180.836519\"\n                }\n              },\n              \"availability\" : {\n                \"standards\" : [ {\n                  \"weekday\" : \"SEGUNDA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"TERCA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUARTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"QUINTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                }, {\n                  \"weekday\" : \"SEXTA_FEIRA\",\n                  \"openingTime\" : \"10:00:57Z\",\n                  \"closingTime\" : \"16:00:57Z\"\n                } ],\n                \"exception\" : \"Exceto feriados municipais, estaduais e nacionais\",\n                \"isPublicAccessAllowed\" : true\n              }\n            } ],\n            \"services\" : [ {\n              \"name\" : \"RECEPCAO_ENCAMINHAMENTO_PROPOSTAS_ABERTURA_CONTAS_DEPOSITOS_VISTA_PRAZO_POUPANCA_MANTIDOS_INSTITUICAO_CONTRATANTE\",\n              \"code\" : \"RECEBE_ENCAMINHA_PROPOSTAS_ABERTURA_CONTAS\",\n              \"additionalInfo\" : \"NA\"\n            }, {\n              \"name\" : \"REALIZACAO_RECEBIMENTOS_PAGAMENTOS_TRANSFERENCIAS_ELETRONICAS_VISANDO_MOVIMENTACAO_CONTAS_DEPOSITOS_TITULARIDADE_CLIENTES_MANTIDAS_INSTITUICAO_CONTRATANTE\",\n              \"code\" : \"REALIZA_RECEBIMENTOS_PAGAMENTOS_TRANSFERENCIAS_ELETRONICAS\",\n              \"additionalInfo\" : \"NA\"\n            }, {\n              \"name\" : \"RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA_OUTRAS_ATIVIDADES_DECORRENTES_EXECUCAO_CONTRATOS_CONVENIOS_PRESTACAO_SERVICOS\",\n              \"code\" : \"RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA_EXECUCAO_CONTRATOS_CONVENIO\",\n              \"additionalInfo\" : \"NA\"\n            } ]\n          } ]\n        } ]\n      } ]\n    }\n  },\n  \"links\" : {\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/banking-agents\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/banking-agents\",\n    \"prev\" : \"null\",\n    \"next\" : \"null\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/banking-agents\"\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ResponseBankingAgentsList>(exampleJson)
                        : default(ResponseBankingAgentsList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Obtém a lista de dependências próprias da instituição financeira.
        /// </summary>
        /// <remarks>Método para obter a lista de dependências próprias da instituição financeira.</remarks>
        /// <response code="200">Lista de dependências próprias obtida com sucesso.</response>
        [HttpGet]
        [Route("/open-banking/channels/v1/branches")]
        [ValidateModelState]
        [SwaggerOperation("GetBranches")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseBranchesList), description: "Lista de dependências próprias obtida com sucesso.")]
        public virtual IActionResult GetBranches()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseBranchesList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"brand\" : {\n      \"name\" : \"Organização A\",\n      \"companies\" : [ {\n        \"name\" : \"Empresa A1\",\n        \"cnpjNumber\" : \"45086338000178\",\n        \"urlComplementaryList\" : \"https://empresaa1.com/branches-banking\",\n        \"branches\" : [ {\n          \"identification\" : {\n            \"type\" : \"AGENCIA\",\n            \"code\" : \"0001\",\n            \"checkDigit\" : \"9\",\n            \"name\" : \"Marília\",\n            \"relatedBranch\" : \"0001\",\n            \"openingDate\" : \"2010-01-02\"\n          },\n          \"postalAddress\" : {\n            \"address\" : \"Av Naburo Ykesaki, 1270\",\n            \"additionalInfo\" : \"Loja B\",\n            \"districtName\" : \"Centro\",\n            \"townName\" : \"Marília\",\n            \"ibgeCode\" : \"3550308\",\n            \"countrySubDivision\" : \"SP\",\n            \"postCode\" : \"17500-001\",\n            \"country\" : \"Brasil\",\n            \"countryCode\" : \"BRA\",\n            \"geographicCoordinates\" : {\n              \"latitude\" : \"-90.8365180\",\n              \"longitude\" : \"-180.836519\"\n            }\n          },\n          \"availability\" : {\n            \"standards\" : [ {\n              \"weekday\" : \"SEGUNDA_FEIRA\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"closingTime\" : \"16:00:57Z\"\n            }, {\n              \"weekday\" : \"TERCA_FEIRA\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"closingTime\" : \"16:00:57Z\"\n            }, {\n              \"weekday\" : \"QUARTA_FEIRA\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"closingTime\" : \"16:00:57Z\"\n            }, {\n              \"weekday\" : \"QUINTA_FEIRA\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"closingTime\" : \"16:00:57Z\"\n            }, {\n              \"weekday\" : \"SEXTA_FEIRA\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"closingTime\" : \"16:00:57Z\"\n            } ],\n            \"exception\" : \"Exceto feriados municipais, estaduais e nacionais\",\n            \"isPublicAccessAllowed\" : true\n          },\n          \"phones\" : [ {\n            \"type\" : \"FIXO\",\n            \"countryCallingCode\" : \"55\",\n            \"areaCode\" : \"14\",\n            \"number\" : \"35721199\"\n          }, {\n            \"type\" : \"MOVEL\",\n            \"countryCallingCode\" : \"55\",\n            \"areaCode\" : \"14\",\n            \"number\" : \"997865532\"\n          } ],\n          \"services\" : [ {\n            \"name\" : \"RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA\",\n            \"code\" : \"RECEBE_PAGA_QUALQUER_NATUREZA\",\n            \"additionalInfo\" : \"Renegociação, Previdência Privada\"\n          }, {\n            \"name\" : \"ABERTURA_CONTAS_DEPOSITOS_OU_PAGAMENTO_PRE_PAGA\",\n            \"code\" : \"ABRE_CONTA_DEPOSITO_OU_PRE_PAGA\",\n            \"additionalInfo\" : \"Renegociação, Previdência Privada\"\n          } ]\n        } ]\n      } ]\n    }\n  },\n  \"links\" : {\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/branches\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/branches\",\n    \"prev\" : \"null\",\n    \"next\" : \"null\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/branches\"\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ResponseBranchesList>(exampleJson)
                        : default(ResponseBranchesList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Obtém a lista de canais eletrônicos de atendimento da instituição financeira.
        /// </summary>
        /// <remarks>Método para obter a lista de canais eletrônicos de atendimento da instituição financeira.</remarks>
        /// <response code="200">Lista de canais eletrônicos de atendimento obtida com sucesso.</response>
        [HttpGet]
        [Route("/open-banking/channels/v1/electronic-channels")]
        [ValidateModelState]
        [SwaggerOperation("GetElectronicChannels")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseElectronicChannelsList), description: "Lista de canais eletrônicos de atendimento obtida com sucesso.")]
        public virtual IActionResult GetElectronicChannels()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseElectronicChannelsList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"brand\" : {\n      \"name\" : \"Organização A\",\n      \"companies\" : [ {\n        \"name\" : \"Empresa A1\",\n        \"cnpjNumber\" : \"45086338000178\",\n        \"urlComplementaryList\" : \"https://empresaa1.com/branches-banking\",\n        \"electronicChannels\" : [ {\n          \"identification\" : {\n            \"type\" : \"INTERNET_BANKING\",\n            \"additionalInfo\" : \"NA\",\n            \"urls\" : [ \"https://empresaa1.com/internet-banking\" ]\n          },\n          \"services\" : [ {\n            \"name\" : \"ABERTURA_CONTAS_DEPOSITOS_OU_PAGAMENTO_PRE_PAGA\",\n            \"code\" : \"ABRE_CONTA_DEPOSITO_OU_PRE_PAGA\",\n            \"additionalInfo\" : \"NA\"\n          }, {\n            \"name\" : \"SEGUROS\",\n            \"code\" : \"SEGUROS\",\n            \"additionalInfo\" : \"NA\"\n          } ]\n        } ]\n      } ]\n    }\n  },\n  \"links\" : {\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/electronic-channels\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/electronic-channels\",\n    \"prev\" : \"null\",\n    \"next\" : \"null\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/electronic-channels\"\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ResponseElectronicChannelsList>(exampleJson)
                        : default(ResponseElectronicChannelsList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Obtém a lista de canais telefônicos de atendimento da instituição financeira.
        /// </summary>
        /// <remarks>Método para obter a lista de canais telefônicos de atendimento da instituição financeira.</remarks>
        /// <response code="200">Lista de canais telefônicos de atendimento obtida com sucesso.</response>
        [HttpGet]
        [Route("/open-banking/channels/v1/phone-channels")]
        [ValidateModelState]
        [SwaggerOperation("GetPhoneChannels")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponsePhoneChannelsList), description: "Lista de canais telefônicos de atendimento obtida com sucesso.")]
        public virtual IActionResult GetPhoneChannels()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponsePhoneChannelsList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"brand\" : {\n      \"name\" : \"Organização A\",\n      \"companies\" : [ {\n        \"name\" : \"Empresa A1\",\n        \"cnpjNumber\" : \"45086338000178\",\n        \"urlComplementaryList\" : \"https://empresaa1.com/branches-banking\",\n        \"phoneChannels\" : [ {\n          \"identification\" : {\n            \"type\" : \"CENTRAL_TELEFONICA\",\n            \"additionalInfo\" : \"NA\",\n            \"phones\" : [ {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"3572-1199\",\n              \"additionalInfo\" : \"NA\"\n            }, {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"99786-5532\",\n              \"additionalInfo\" : \"NA\"\n            } ]\n          },\n          \"services\" : [ {\n            \"name\" : \"ABERTURA_CONTAS_DEPOSITOS_OU_PAGAMENTO_PRE_PAGA\",\n            \"code\" : \"ABRE_CONTA_DEPOSITO_OU_PRE_PAGA\",\n            \"additionalInfo\" : \"NA\"\n          }, {\n            \"name\" : \"RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA\",\n            \"code\" : \"RECEBE_PAGA_QUALQUER_NATUREZA\",\n            \"additionalInfo\" : \"NA\"\n          } ]\n        }, {\n          \"identification\" : {\n            \"type\" : \"SAC\",\n            \"additionalInfo\" : \"NA\",\n            \"phones\" : [ {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-4828\",\n              \"additionalInfo\" : \"DDI '55'; DDD '11', 40044828, 'Para clientes no exterior'\"\n            }, {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-4828\",\n              \"additionalInfo\" : \"DDI ' ', DDD ' ', 40044828, 'Para regiões metropolitanas'\"\n            }, {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-4828\",\n              \"additionalInfo\" : \"DDI ' ', DDD ' ', 40044828, 'Para demais localidades'\"\n            } ]\n          },\n          \"services\" : [ {\n            \"name\" : \"RECLAMACOES\",\n            \"code\" : \"RECLAMACOES\",\n            \"additionalInfo\" : \"NA\"\n          }, {\n            \"name\" : \"INFORMACOES\",\n            \"code\" : \"INFORMACOES\",\n            \"additionalInfo\" : \"NA\"\n          }, {\n            \"name\" : \"CANCELAMENTO\",\n            \"code\" : \"CANCELAMENTO\",\n            \"additionalInfo\" : \"NA\"\n          } ]\n        }, {\n          \"identification\" : {\n            \"type\" : \"OUVIDORIA\",\n            \"additionalInfo\" : \"NA\",\n            \"phones\" : [ {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-5555\",\n              \"additionalInfo\" : \"DDI '55'; DDD '11', 40045555, 'Para clientes no exterior'\"\n            }, {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-5555\",\n              \"additionalInfo\" : \"DDI ' ', DDD ' ', 40045555, 'Para regiões metropolitanas'\"\n            }, {\n              \"countryCallingCode\" : \"55\",\n              \"areaCode\" : \"14\",\n              \"number\" : \"4004-5555\",\n              \"additionalInfo\" : \"DDI ' ', DDD ' ', 40045555, 'Para demais localidades'\"\n            } ]\n          },\n          \"services\" : [ {\n            \"name\" : \"RECLAMACOES\",\n            \"code\" : \"RECLAMACOES\",\n            \"additionalInfo\" : \"NA\"\n          }, {\n            \"name\" : \"INFORMACOES\",\n            \"code\" : \"INFORMACOES\",\n            \"additionalInfo\" : \"NA\"\n          } ]\n        } ]\n      } ]\n    }\n  },\n  \"links\" : {\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/phone-channels\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/phone-channels\",\n    \"prev\" : \"null\",\n    \"next\" : \"null\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/phone-channels\"\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ResponsePhoneChannelsList>(exampleJson)
                        : default(ResponsePhoneChannelsList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Obtém a lista de terminais compartilhados de autoatendimento.
        /// </summary>
        /// <remarks>Método para obter a lista de terminais compartilhados de autoatendimento da instituição financeira.</remarks>
        /// <response code="200">Lista de terminais compartilhados de autoatendimento obtida com sucesso.</response>
        [HttpGet]
        [Route("/open-banking/channels/v1/shared-automated-teller-machines")]
        [ValidateModelState]
        [SwaggerOperation("GetSharedAutomatedTellerMachines")]
        [SwaggerResponse(statusCode: 200, type: typeof(ResponseSharedAutomatedTellerMachinesList), description: "Lista de terminais compartilhados de autoatendimento obtida com sucesso.")]
        public virtual IActionResult GetSharedAutomatedTellerMachines()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ResponseSharedAutomatedTellerMachinesList));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"brand\" : {\n      \"companies\" : [ {\n        \"sharedAutomatedTellerMachines\" : [ {\n          \"identification\" : {\n            \"ownerName\" : \"João da Silva Santos\"\n          },\n          \"postalAddress\" : {\n            \"country\" : \"Brasil\",\n            \"townName\" : \"Marília\",\n            \"geographicCoordinates\" : {\n              \"latitude\" : \"-90.8365180\",\n              \"longitude\" : \"-180.836519\"\n            },\n            \"address\" : \"Av Naburo Ykesaki, 1270\",\n            \"districtName\" : \"Centro\",\n            \"ibgeCode\" : \"3515890\",\n            \"countrySubDivision\" : \"SP\",\n            \"countryCode\" : \"BRA\",\n            \"additionalInfo\" : \"Fundos\",\n            \"postCode\" : \"17500001\"\n          },\n          \"availability\" : {\n            \"standards\" : [ {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            }, {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            } ],\n            \"exception\" : \"Exceto feriados municipais, nacionais e estaduais\",\n            \"isPublicAccessAllowed\" : false\n          },\n          \"services\" : [ {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          }, {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          } ]\n        }, {\n          \"identification\" : {\n            \"ownerName\" : \"João da Silva Santos\"\n          },\n          \"postalAddress\" : {\n            \"country\" : \"Brasil\",\n            \"townName\" : \"Marília\",\n            \"geographicCoordinates\" : {\n              \"latitude\" : \"-90.8365180\",\n              \"longitude\" : \"-180.836519\"\n            },\n            \"address\" : \"Av Naburo Ykesaki, 1270\",\n            \"districtName\" : \"Centro\",\n            \"ibgeCode\" : \"3515890\",\n            \"countrySubDivision\" : \"SP\",\n            \"countryCode\" : \"BRA\",\n            \"additionalInfo\" : \"Fundos\",\n            \"postCode\" : \"17500001\"\n          },\n          \"availability\" : {\n            \"standards\" : [ {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            }, {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            } ],\n            \"exception\" : \"Exceto feriados municipais, nacionais e estaduais\",\n            \"isPublicAccessAllowed\" : false\n          },\n          \"services\" : [ {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          }, {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          } ]\n        } ]\n      }, {\n        \"sharedAutomatedTellerMachines\" : [ {\n          \"identification\" : {\n            \"ownerName\" : \"João da Silva Santos\"\n          },\n          \"postalAddress\" : {\n            \"country\" : \"Brasil\",\n            \"townName\" : \"Marília\",\n            \"geographicCoordinates\" : {\n              \"latitude\" : \"-90.8365180\",\n              \"longitude\" : \"-180.836519\"\n            },\n            \"address\" : \"Av Naburo Ykesaki, 1270\",\n            \"districtName\" : \"Centro\",\n            \"ibgeCode\" : \"3515890\",\n            \"countrySubDivision\" : \"SP\",\n            \"countryCode\" : \"BRA\",\n            \"additionalInfo\" : \"Fundos\",\n            \"postCode\" : \"17500001\"\n          },\n          \"availability\" : {\n            \"standards\" : [ {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            }, {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            } ],\n            \"exception\" : \"Exceto feriados municipais, nacionais e estaduais\",\n            \"isPublicAccessAllowed\" : false\n          },\n          \"services\" : [ {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          }, {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          } ]\n        }, {\n          \"identification\" : {\n            \"ownerName\" : \"João da Silva Santos\"\n          },\n          \"postalAddress\" : {\n            \"country\" : \"Brasil\",\n            \"townName\" : \"Marília\",\n            \"geographicCoordinates\" : {\n              \"latitude\" : \"-90.8365180\",\n              \"longitude\" : \"-180.836519\"\n            },\n            \"address\" : \"Av Naburo Ykesaki, 1270\",\n            \"districtName\" : \"Centro\",\n            \"ibgeCode\" : \"3515890\",\n            \"countrySubDivision\" : \"SP\",\n            \"countryCode\" : \"BRA\",\n            \"additionalInfo\" : \"Fundos\",\n            \"postCode\" : \"17500001\"\n          },\n          \"availability\" : {\n            \"standards\" : [ {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            }, {\n              \"closingTime\" : \"16:00:57Z\",\n              \"openingTime\" : \"10:00:57Z\",\n              \"weekday\" : \"SEGUNDA_FEIRA\"\n            } ],\n            \"exception\" : \"Exceto feriados municipais, nacionais e estaduais\",\n            \"isPublicAccessAllowed\" : false\n          },\n          \"services\" : [ {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          }, {\n            \"code\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"name\" : \"OUTROS_PRODUTOS_SERVICOS\",\n            \"additionalInfo\" : \"Serviços complementares de atendimento via terminais de autoatendimento.\"\n          } ]\n        } ]\n      } ]\n    }\n  },\n  \"meta\" : {\n    \"totalRecords\" : 1,\n    \"totalPages\" : 1\n  },\n  \"links\" : {\n    \"next\" : \"next\",\n    \"last\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"prev\" : \"prev\",\n    \"self\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\",\n    \"first\" : \"https://api.banco.com.br/open-banking/channels/v1/<resource>\"\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ResponseSharedAutomatedTellerMachinesList>(exampleJson)
                        : default(ResponseSharedAutomatedTellerMachinesList);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
