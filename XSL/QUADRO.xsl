<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:variable name="mes" select="number(root/config/mes)"/>
<xsl:variable name="ano" select="number(root/config/ano)"/>
<xsl:variable name="cor1" select="/root/config/cor1/text()"/>
<xsl:variable name="cor2" select="/root/config/cor2/text()"/>
    
<xsl:template name="Header">
  <xsl:param name="titulo" />
  <div class="header">
    <xsl:attribute name="style">
      <xsl:value-of select="concat('background: repeating-linear-gradient(45deg, ', $cor1, ', ', $cor1, ' 1mm, ', $cor2, ' 1mm, ', $cor2, ' 2mm);')"/>
    </xsl:attribute>
    
    <div class="header-titulo"><xsl:value-of select="$titulo" /></div>
    <div class="header-mes">
	  <xsl:if test="$titulo != 'Grupos espirituais'"> 
        <xsl:call-template name="Mes">
          <xsl:with-param name="mes" select='$mes'/>
        </xsl:call-template>
        &#160;<xsl:value-of select="$ano" />
	  </xsl:if>
    </div>
  </div>
</xsl:template>
  
<xsl:template name="Mes">
  <xsl:param name="mes" />
  <xsl:choose>
      <xsl:when test="$mes = 1">Janeiro</xsl:when>
      <xsl:when test="$mes = 2">Fevereiro</xsl:when>
      <xsl:when test="$mes = 3">Março</xsl:when>
      <xsl:when test="$mes = 4">Abril</xsl:when>
      <xsl:when test="$mes = 5">Maio</xsl:when>
      <xsl:when test="$mes = 6">Junho</xsl:when>
      <xsl:when test="$mes = 7">Julho</xsl:when>
      <xsl:when test="$mes = 8">Agosto</xsl:when>
      <xsl:when test="$mes = 9">Setembro</xsl:when>
      <xsl:when test="$mes = 10">Outubro</xsl:when>
      <xsl:when test="$mes = 11">Novembro</xsl:when>
      <xsl:when test="$mes = 12">Dezembro</xsl:when>
      <xsl:otherwise>error: <xsl:value-of select="$mes"/></xsl:otherwise>
  </xsl:choose>
</xsl:template>
    
<xsl:template name="NVMC_Item">
  <xsl:param name="idx" />
  
  <div class="linha-data">
    <xsl:attribute name="style">
      <xsl:value-of select="concat('border-color: ', $cor1, ';')"/>
    </xsl:attribute>
    <div>
      <xsl:attribute name="style">
        <xsl:value-of select="concat('border-color: ', $cor1, '; color: ', $cor1, ';')"/>
      </xsl:attribute>
      <span class="icone icone-secao icone-calendario"></span>
      <div class="linha-data-txt">
        <xsl:value-of select="/root/semanas/Estrutura[$idx]/FormatadoMeioSemana/text()" />
      </div>
    </div>
  </div>

  <xsl:choose>
    <xsl:when test="/root/semanas/Estrutura[$idx]/Assembleia = 'true'">
      <h2>SEMANA DE ASSEMBLÉIA DE CIRCUITO</h2>
    </xsl:when>
    <xsl:when test="/root/semanas/Estrutura[$idx]/Congresso = 'true'">
      <h2>SEMANA DO CONGRESSO REGIONAL</h2>
    </xsl:when>
    <xsl:otherwise>
      <table style="width:100%;">
        <tr>
          <td style="width:60%;">
            <div class="secao">
              <div class="parte">
                <div class="parte-titulo inline">Presidente: </div>
                <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Presidente/text()" /></div>
              </div>
              <div class="parte">
                <div class="parte-titulo inline">Oração inicial: </div>
                <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Oracao_Inicial/text()" /></div>
              </div>
              <div data-cor="1" class="titulo-secao">TESOUROS DA PALAVRA DE DEUS</div>
              <div class="parte">
                <div class="parte-titulo">(10 min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_DiscursoTema/text()" /></div>
                <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_DiscursoDesignado/text()" /></div>
              </div>
              <div class="parte">
                <div class="parte-titulo">(8 min) Encontre jóias espirituais</div>
                <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Joias/text()" /></div>
              </div>
              <div class="parte">
                <div class="parte-titulo">(4 min) Leitura da Bíblia</div>
                <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_Leitura/text()" /></div>
                <xsl:if test="/root/semanas/Estrutura[$idx]/SalaB/text() = 'true'">
                  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_Leitura/text()" /> <i>(Sala B)</i></div>
                </xsl:if>
              </div>
          
              <div class="titulo-secao" data-cor="3">NOSSA VIDA CRISTÃ</div>
              <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Tema/text() != ''">
                <div class="parte">
                  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Tema/text()" /></div>
                  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Designado/text()" /></div>
                </div>
              </xsl:if>
              <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Tema/text() != ''">
                <div class="parte">
                  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Tema/text()" /></div>
                  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Designado/text()" /></div>
                </div> 
              </xsl:if>
              <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Tema/text() != ''">
                <div class="parte">
                  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Tema/text()" /></div>
                  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Designado/text()" /></div>
                </div>
              </xsl:if>
              <xsl:choose>
                <xsl:when test="/root/semanas/Estrutura[$idx]/VisitaSup = 'true'">
                  <div class="parte">
                    <div class="parte-titulo">VISITA DO SUPERINTENDENTE</div>
                  </div>
                </xsl:when>
                <xsl:otherwise>
                  <div class="parte">
                    <div class="parte-titulo">(30 min) Estudo Bíblico de Congregação</div>
                    <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_EBC_Dirigente/text()" /></div>
                    <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_EBC_Leitor/text()" /><i>(Leitor)</i></div>
                  </div>
                </xsl:otherwise>
              </xsl:choose>
            </div>
          </td>
          <td>
            <div class="parte">
              <div class="parte-titulo-sem inline"></div>
              <div class="parte-nome"></div>
            </div>
            <div class="parte">
              <div class="parte-titulo inline">Oração final: </div>
              <div class="parte-nome">
                <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Oracao_Final/text()" />
              </div>
            </div>
            <div class="secao">
              <div class="titulo-secao" data-cor="2">FAÇA SEU MELHOR NO MINISTÉRIO</div>
              <xsl:if test="/root/semanas/Estrutura[$idx]/PrimeiraSemana/text() = 'true'">
                  <div class="parte">
                    <div class="parte-titulo">(15 min) Prepare as apresentações deste mês</div>
                    <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_Dirigente/text()" /></div>
                  </div>
              </xsl:if>
              <xsl:if test="/root/semanas/Estrutura[$idx]/PrimeiraSemana/text() = 'false'">
                <div class="parte">
                  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomePrimeiraParte/text() != ''">
                    <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomePrimeiraParte/text()" /></div>
                    <div class="parte-nome">
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_PrimeiraParteDesignado/text()" /> / 
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_PrimeiraParteAjudante/text()" />
                    </div>
                  </xsl:if>
                </div>
                <div class="parte">
                  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeSegundaParte/text() != ''">
                    <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeSegundaParte/text()" /></div>
                    <div class="parte-nome">
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_SegundaParteDesignado/text()" /> / 
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_SegundaParteAjudante/text()" />
                    </div>
                  </xsl:if>
                </div>
                <div class="parte">
                  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeTerceiraParte/text() != ''">
                  <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeTerceiraParte/text()" /></div>
                  <div class="parte-nome">
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_TerceiraParteDesignado/text()" /> / 
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_TerceiraParteAjudante/text()" />
                  </div>
                  </xsl:if>
                </div>
                <div class="parte">
                  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeQuartaParte/text() != ''">
                    <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeQuartaParte/text()" /></div>
                    <div class="parte-nome">
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_QuartaParteDesignado/text()" /> / 
                      <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_QuartaParteAjudante/text()" />
                    </div>
                  </xsl:if>
                </div>
                <xsl:if test="/root/semanas/Estrutura[$idx]/SalaB/text() = 'true'">
                  <div class="titulo-secao" data-cor="2">SALA B</div>
                  <div class="parte">
                    <div class="parte-titulo inline">Dirigente: </div>
                    <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_Dirigente/text()" /></div>
                  </div>
                  <div class="parte">
                    <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomePrimeiraParte/text() != ''">
                      <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomePrimeiraParte/text()" /></div>
                      <div class="parte-nome">
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_PrimeiraParteDesignado/text()" /> / 
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_PrimeiraParteAjudante/text()" />
                      </div>
                    </xsl:if>
                  </div>
                  <div class="parte">
                    <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeSegundaParte/text() != ''">
                      <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeSegundaParte/text()" /></div>
                      <div class="parte-nome">
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_SegundaParteDesignado/text()" /> / 
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_SegundaParteAjudante/text()" />
                      </div>
                    </xsl:if>
                  </div>
                  <div class="parte">
                    <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeTerceiraParte/text() != ''">
                      <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeTerceiraParte/text()" /></div>
                      <div class="parte-nome">
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_TerceiraParteDesignado/text()" /> / 
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_TerceiraParteAjudante/text()" />
                      </div>
                    </xsl:if>
                  </div>
                  <div class="parte">
                    <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_NomeQuartaParte/text() != ''">
                      <div class="parte-titulo"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_NomeQuartaParte/text()" /></div>
                      <div class="parte-nome">
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_QuartaParteDesignado/text()" /> / 
                        <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_QuartaParteAjudante/text()" />
                      </div>
                    </xsl:if>
                  </div>
                </xsl:if>
              </xsl:if>
            </div>
          </td>
        </tr>
      </table>
    </xsl:otherwise>
  </xsl:choose>
</xsl:template>
  
<xsl:template name="RP">
  <xsl:param name="idx" />
  <div class="linha-data">
    <xsl:attribute name="style">
      <xsl:value-of select="concat('border-color: ', $cor1, ';')"/>
    </xsl:attribute>
    <div>
      <xsl:attribute name="style">
        <xsl:value-of select="concat('border-color: ', $cor1, '; color: ', $cor1, ';')"/>
      </xsl:attribute>
      <span class="icone icone-secao icone-calendario"></span>
      <div class="linha-data-txt">
        <xsl:value-of select="/root/semanas/Estrutura[$idx]/FormatadoFimSemana/text()" />
      </div>
    </div>
  </div>
  <xsl:choose>
    <xsl:when test="/root/semanas/Estrutura[$idx]/Assembleia = 'true'">
      <h2>SEMANA DE ASSEMBLÉIA DE CIRCUITO</h2>
    </xsl:when>
    <xsl:when test="/root/semanas/Estrutura[$idx]/Congresso = 'true'">
      <h2>SEMANA DO CONGRESSO REGIONAL</h2>
    </xsl:when>
    <xsl:otherwise>
      <table style="width:100%;">
        <tr>
          <td style="width:60%;">
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx]/VisitaSup = 'true'">
                <div class="titulo-secao" data-cor="1">REUNIÃO PÚBLICA</div>
                <div class="parte">
                  <div class="parte-titulo inline">Presidente: </div>
                  <div class="parte-nome">
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Presidente/text()" />
                  </div>
                </div>
                <div class="parte">
                  <div class="parte-titulo">
                    VISITA DO SUPERINTENDENTE DE CIRCUITO
                  </div>
                </div>
              </xsl:when>
              <xsl:otherwise>
                <div class="titulo-secao" data-cor="1">REUNIÃO PÚBLICA</div>
                <div class="parte">
                  <div class="parte-titulo inline">Presidente: </div>
                  <div class="parte-nome">
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Presidente/text()" />
                  </div>
                </div>
                <div class="parte">
                  <div class="parte-titulo">
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Discurso_Tema/text()" />
                  </div>
                  <div class="parte-nome">
                    <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Discurso_Orador/text()" />
                    <xsl:if test="/root/semanas/Estrutura[$idx]/RP_Discurso_Congregacao/text() != ''">
                      (Cong. <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Discurso_Congregacao/text()" />)
                    </xsl:if>
                  </div>
                </div>
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <div class="titulo-secao" data-cor="2">ESTUDO DE A SENTINELA</div>
            <div class="parte">
              <div class="parte-titulo">Leitor</div>
              <div class="parte-nome">
                <xsl:value-of select="/root/semanas/Estrutura[$idx]/RP_Sentinela_Leitor/text()" />
              </div>
            </div>
          </td>
        </tr>
      </table>
    </xsl:otherwise>
  </xsl:choose>
</xsl:template>
<xsl:template name="DS">
  <xsl:param name="idx1" />
  <xsl:param name="idx2" />
  <xsl:param name="idx3" />
  <xsl:param name="idx4" />
  <xsl:param name="idx5" />
  <div class="A4">
      <xsl:call-template name="Header">
        <xsl:with-param name="titulo" select='"Designações de Serviço"'/>
      </xsl:call-template>
      <table class='ds'>
        <tr>
          <xsl:attribute name="style">
            <xsl:value-of select="concat('border-color: ', $cor1, '; color: ', $cor1, ';')"/>
          </xsl:attribute>
          <td colspan='2'>
			      <div class='titulo-secao' style="width:100%;" data-cor="0">SEMANAS</div><br />
          </td>
		      <td style="text-align: center;">
            <div style="width:100%"><xsl:value-of select="/root/semanas/Estrutura[$idx1]/FormatadoSemana2/text()"/></div>
          </td>
          <td style="text-align: center;">
            <div style="width:100%"><xsl:value-of select="/root/semanas/Estrutura[$idx2]/FormatadoSemana2/text()"/></div>
          </td>
          <td style="text-align: center;">
            <div style="width:100%"><xsl:value-of select="/root/semanas/Estrutura[$idx3]/FormatadoSemana2/text()"/></div>
          </td>
          <td style="text-align: center;">
            <div style="width:100%"><xsl:value-of select="/root/semanas/Estrutura[$idx4]/FormatadoSemana2/text()"/></div>
          </td>
          <td style="text-align: center;">
            <div style="width:100%"><xsl:value-of select="/root/semanas/Estrutura[$idx5]/FormatadoSemana2/text()"/></div>
          </td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr class='min-height'>
          <td rowspan='2'  style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="1">IND MEIO SEMANA</div><br />
            <span class='icone icone-secao icone-indicador'></span>
          </td>
          <td><div class='parte-titulo'>Indicadores:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Indicador_MS/text()"/><br />
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Indicador_MS/text()"/><br />
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Indicador_MS/text()"/><br />
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Indicador_MS/text()"/><br />
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Indicador_MS/text()"/><br />
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr class='min-height'>
          <td rowspan='2'  style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="1">IND FIM SEMANA</div>
            <br />
            <span class='icone icone-secao icone-indicador'></span>
          </td>
          <td>
            <div class='parte-titulo'>Indicadores:</div>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Indicador_FS/text()"/>
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Indicador_FS/text()"/>
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Indicador_FS/text()"/>
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Indicador_FS/text()"/>
              </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Indicador_FS/text()"/>
              </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr class='min-height'>
          <td rowspan='5'  style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="2">SOM MEIO SEMANA</div><br />
            <span class='icone icone-secao icone-som'></span>
          </td>
          <td><div class='parte-titulo'>Vídeo:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Video_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Video_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Video_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Video_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Video_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr class='min-height'>
          <td><div class='parte-titulo'>Audio:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Audio_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Audio_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Audio_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Audio_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Audio_MS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr>
          <td colspan="6"></td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>

        <tr class='min-height'>
          <td rowspan='5'  style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="2">SOM FIM SEMANA</div><br />
            <span class='icone icone-secao icone-som'></span>
          </td>
          <td><div class='parte-titulo'>Vídeo:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Video_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Video_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Video_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Video_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Video_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr class='min-height'>
          <td><div class='parte-titulo'>Audio:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Audio_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Audio_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Audio_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Audio_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Audio_FS/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr class='min-height'>
          <td rowspan='4' style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="3">BRIG. INCÊNDIO</div><br />
            <span class='icone icone-secao icone-extintor'></span>
          </td>
          <td><div class='parte-titulo'>C. Turno:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Brigada_ChefeTurno/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Brigada_ChefeTurno/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Brigada_ChefeTurno/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Brigada_ChefeTurno/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Brigada_ChefeTurno/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr class='min-height'>
          <td><div class='parte-titulo'>Líder:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Brigada_Lider/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Brigada_Lider/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Brigada_Lider/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Brigada_Lider/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Brigada_Lider/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr class='min-height'>
          <td><div class='parte-titulo'>Brigadistas:</div></td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx1]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Brigada_Brigadista1/text()"/><br />
                <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Brigada_Brigadista2/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx2]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Brigada_Brigadista1/text()"/><br />
                <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Brigada_Brigadista2/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx3]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Brigada_Brigadista1/text()"/><br />
                <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Brigada_Brigadista2/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx4]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Brigada_Brigadista1/text()"/><br />
                <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Brigada_Brigadista2/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
          <td>
            <xsl:choose>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Assembleia = 'true'"></xsl:when>
              <xsl:when test="/root/semanas/Estrutura[$idx5]/Congresso = 'true'"></xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Brigada_Brigadista1/text()"/><br />
                <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Brigada_Brigadista2/text()"/>
                </xsl:otherwise>
            </xsl:choose>
          </td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
        <tr class='min-height'>
          <td rowspan='3'  style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="4">LIMPEZA</div><br />
            <span class='icone icone-secao icone-gota'></span>
          </td>
          <td><div class='parte-titulo'>Grupo:</div></td>
          <td>
            <b><xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Limpeza_Grupo/text()"/></b>
          </td>
          <td>
            <b><xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Limpeza_Grupo/text()"/></b>
          </td>
          <td>
            <b><xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Limpeza_Grupo/text()"/></b>
          </td>
          <td>
            <b><xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Limpeza_Grupo/text()"/></b>
          </td>
          <td>
            <b><xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Limpeza_Grupo/text()"/></b>
          </td>
        </tr>
        <tr class='min-height'>
          <td><div class='parte-titulo'>Dirigente:</div></td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Limpeza_Dirigente/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Limpeza_Dirigente/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Limpeza_Dirigente/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Limpeza_Dirigente/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Limpeza_Dirigente/text()"/>
          </td>
        </tr>
        <tr>
          <td colspan='5'></td>
        </tr>
        <tr>
          <td colspan='6'></td>
        </tr>
                <tr>
          <td>
            <div class="titulo-secao" style="width:100%;" data-cor="5">TRANSPORTE</div>
          </td>
        </tr>  
        <tr class='min-height'>
          <td style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="5">Meio Semana</div><br />
            <span class='icone icone-secao icone-transporte'></span>
          </td>
          <td><div class='parte-titulo'>Responsável:</div></td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Transporte_MS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Transporte_MS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Transporte_MS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Transporte_MS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Transporte_MS/text()"/>
          </td>
        </tr>

		    <tr class='min-height'>
          <td style="text-align:left;">
            <div class='titulo-secao' style="width:100%;" data-cor="5">Fim Semana</div><br />
            <span class='icone icone-secao icone-transporte'></span>
          </td>
          <td><div class='parte-titulo'>Responsável:</div></td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx1]/DS_Transporte_FS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx2]/DS_Transporte_FS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx3]/DS_Transporte_FS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx4]/DS_Transporte_FS/text()"/>
          </td>
          <td>
            <xsl:value-of select="/root/semanas/Estrutura[$idx5]/DS_Transporte_FS/text()"/>
          </td>
        </tr>
	</table>
    </div>
</xsl:template>
  
<xsl:template match="/">
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="font-awesome.css" />
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link rel="stylesheet" type="text/css" href="main.css" />
    <style type="text/css">
      div.A4 {
          width: 22cm;
          height: 29.7cm;
          margin: 0;
          padding: 5mm 5mm;
          outline: 1px solid silver;
          font-size: 12.5pt;
          font-weight: 300;
          letter-spacing: -0.025em;
      }

      div.A4Landscape {
          height: 21cm;
          width: 29.7cm;
          margin: 0;
          padding: 5mm 5mm;
          outline: 1px solid silver;
          font-size: 12.5pt;
          font-weight: 300;
          letter-spacing: -0.025em;
      }

      .header {
          display: table;
          width: calc(100% + 10mm);
          height: 30mm;
          background: #333;
          color: white;
          margin-left: -5mm;
          margin-top: -5mm;
          margin-bottom: 8mm;
      }

      .header-titulo {
          display: table-cell;
          vertical-align: bottom;
          padding-left: 10mm;
          padding-bottom: 5mm;
          font-size: 28pt;
          letter-spacing: -1pt;
      }

      .header-mes {
          display: table-cell;
          vertical-align: bottom;
          text-align: right;
          padding-right: 10mm;
          padding-bottom: 5mm;
          font-size: 18pt;
      }

      .linha-data {
          margin: 5mm 0;
          font-size: 18pt;
          border-top: 0.5mm solid #333;
      }
      .icone {
          display: inline-block;
          font: normal normal normal 14px/1 FontAwesome;
          font-size: inherit;
          text-rendering: auto;
          -webkit-font-smoothing: antialiased;
      }
      .icone-secao {
          font-size: 50pt;
          margin-top: 2mm;
          margin-right: 2mm;
      }

      .icone-calendario {
          background-image: url('calendario.png');
          width: 26px;
          height: 28px;
      }

      .icone-extintor {
          background-image: url('extintor.png');
          width: 58px;
          height: 65px;
      }

      .icone-gota {
          background-image: url('gota.png');
          width: 48px;
          height: 60px;
      }

      .icone-indicador {
          background-image: url('indicador.png');
          width: 58px;
          height: 61px;
      }

      .icone-som {
          background-image: url('som.png');
          width: 66px;
          height: 62px;
      }

      .icone-transporte {
          background-image: url('transporte.png');
          width: 76px;
          height: 46px;
      }

      .icone-marcador {
          background-image: url('marcador.png');
          width: 65px;
          height: 65px;
      }
    
    </style>
    
  </head>
  <body>
    <xsl:variable name="qtdReuniaoMeioSemana" select="count(root/semanas/Estrutura/Mes[number(text()) = $mes])"/>
    <xsl:if test="$qtdReuniaoMeioSemana = 4">
      <div class="A4">
        <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='1'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='2'/>
        </xsl:call-template>
      </div>
      <div class="A4">
        <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='3'/>
        </xsl:call-template>
      <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='4'/>
        </xsl:call-template>
      </div>
    </xsl:if>
    <xsl:if test="$qtdReuniaoMeioSemana = 5">
      <div class="A4">
        <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='1'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='2'/>
        </xsl:call-template>
      </div>
      <div class="A4">
        <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='3'/>
        </xsl:call-template>
		<xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='4'/>
        </xsl:call-template>
      </div>
      <div class="A4">
        <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
        </xsl:call-template>
        <xsl:call-template name="NVMC_Item">
          <xsl:with-param name="idx" select='5'/>
        </xsl:call-template>
      </div>
    </xsl:if>
    <div class="A4">
      <xsl:call-template name="Header">
          <xsl:with-param name="titulo" select='"Reunião Pública e A Sentinela"'/>
      </xsl:call-template>
      <xsl:for-each select="/root/semanas/Estrutura">
		<xsl:variable name="dt" select="number(Mes)"/>
        <xsl:if test="$dt = $mes">
          <xsl:call-template name="RP">
            <xsl:with-param name="idx" select='position()'/>
          </xsl:call-template>
        </xsl:if>
      </xsl:for-each>
    </div>
    
    <xsl:variable name="qtdSemanas" select="count(root/semanas/Estrutura/Data)"/>
    <xsl:if test="$qtdSemanas = 4">
      <xsl:call-template name="DS">
        <xsl:with-param name="idx1" select='1'/>
        <xsl:with-param name="idx2" select='2'/>
        <xsl:with-param name="idx3" select='3'/>
        <xsl:with-param name="idx4" select='4'/>
      </xsl:call-template>
    </xsl:if>
    <xsl:if test="$qtdSemanas = 5">
      <xsl:call-template name="DS">
        <xsl:with-param name="idx1" select='1'/>
        <xsl:with-param name="idx2" select='2'/>
        <xsl:with-param name="idx3" select='3'/>
        <xsl:with-param name="idx4" select='4'/>
		    <xsl:with-param name="idx5" select='5'/>
      </xsl:call-template>
    </xsl:if>
  </body>
</html>
</xsl:template>
</xsl:stylesheet>