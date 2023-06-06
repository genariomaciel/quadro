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
      <xsl:value-of select="concat('background: repeating-linear-gradient(45deg, ', $cor1, ', ', $cor1, ' 1mm, ', $cor2, ' 1mm, ', $cor2, ' 2mm);height: 25mm;')"/>
    </xsl:attribute>
    
    <div class="header-titulo"><xsl:value-of select="$titulo" /></div>
    <div class="header-mes">
      <xsl:call-template name="Mes">
        <xsl:with-param name="mes" select='$mes'/>
      </xsl:call-template>
      &#160;<xsl:value-of select="$ano" />
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
    <xsl:when test="/root/semanas/Estrutura[$idx]/NVMC_Presidente/text() != ''">
	  <div class="parte parte-fixed">
		<div class="parte-titulo">Presidente: </div>
		<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Presidente/text()" /></div>
	  </div>
	  <div data-cor="1" class="titulo-secao">TESOUROS DA PALAVRA DE DEUS</div>
	  <div class="parte parte-fixed">
		<div class="parte-titulo">(10 min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_DiscursoTema/text()" /></div>
		<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_DiscursoDesignado/text()" /></div>
	  </div>
	  <div class="parte parte-fixed">
		<div class="parte-titulo">(8 min) Encontre jóias espirituais</div>
		<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Joias/text()" /></div>
	  </div>
	  <div class="titulo-secao" data-cor="2">FAÇA SEU MELHOR NO MINISTÉRIO</div>
	  <xsl:if test="/root/semanas/Estrutura[$idx]/PrimeiraSemana/text() = 'true'">
		  <div class="parte parte-fixed">
			<div class="parte-titulo">(15 min) Prepare as apresentações deste mês</div>
			<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_Dirigente/text()" /></div>
		  </div>
	  </xsl:if>
	  <xsl:if test="/root/semanas/Estrutura[$idx]/PrimeiraSemana/text() = 'false'">
		<xsl:if test="/root/semanas/Estrutura[$idx]/SalaB/text() = 'false'">
		  <div class="parte parte-fixed">
			<div class="parte-titulo inline">Sala A: </div>
				<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_Dirigente/text()" /></div>
		  </div>
		  </xsl:if>
		  <xsl:if test="/root/semanas/Estrutura[$idx]/SalaB/text() = 'true'">
			  <div class="parte parte-fixed">
				<div>
					<div class="parte-titulo inline">Sala A: </div>
					<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaA_Dirigente/text()" /></div>
				</div>
				<div>
					<div class="parte-titulo inline">Sala B: </div>
					<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_SalaB_Dirigente/text()" /></div>
				</div>
			  </div>
		  </xsl:if>
	  </xsl:if>
	  <div class="titulo-secao" data-cor="3">NOSSA VIDA CRISTÃ</div>
	  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Tema/text() != ''">
		<div class="parte parte-fixed">
		  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Tema/text()" /></div>
		  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte1_Designado/text()" /></div>
		</div>
	  </xsl:if>
	  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Tema/text() != ''">
		<div class="parte parte-fixed">
		  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Tema/text()" /></div>
		  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte2_Designado/text()" /></div>
		</div>
	  </xsl:if>
	  <xsl:if test="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Tema/text() != ''">
		<div class="parte parte-fixed">
		  <div class="parte-titulo">(<xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Dur/text()" /> min) <xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Tema/text()" /></div>
		  <div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_Parte3_Designado/text()" /></div>
		</div>
	  </xsl:if>
	  <xsl:choose>
		<xsl:when test="/root/semanas/Estrutura[$idx]/VisitaSup = 'true'">
		  <div class="parte parte-fixed">
			<div class="parte-titulo">VISITA DO SUPERINTENDENTE</div>
		  </div>
		</xsl:when>
		<xsl:otherwise>
		  <div class="parte parte-fixed">
			<div class="parte-titulo">(30 min) Estudo Bíblico de Congregação</div>
			<div class="parte-nome"><xsl:value-of select="/root/semanas/Estrutura[$idx]/NVMC_EBC_Dirigente/text()" /></div>
		  </div>
		</xsl:otherwise>
	  </xsl:choose>
	</xsl:when>  
    <xsl:otherwise>
	</xsl:otherwise>
  </xsl:choose>
</xsl:template>
  
<xsl:template match="/">
<html>
  <head>
    <link rel="stylesheet" type="text/css" href="font-awesome.css" />
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link rel="stylesheet" type="text/css" href="main.css" />
	<style type="text/css">

    div.A4 {
    font-size: 11pt;
    }

    .parte-fixed {
    display: table;
    width: 100%;
    }

    .parte-fixed > div {
    display: table-cell;
    }

    .parte-fixed > div:last-child {
    white-space: nowrap;
    text-align: right;
    }

    .parte-fixed > div:first-child {
    max-width: 90mm;
    }

    .parte-nome {
    font-weight: 500;
    }

    .parte {
    margin-top: 0.8mm;
    margin-bottom: 0.8mm;
    }

    .header {
    margin-bottom: 3mm;
    }

    .linha-data {
    font-size: 15pt;
    margin-bottom: 3mm;
    }

    .titulo-secao ~ .titulo-secao {
    margin-top: 1mm;
    }

    .titulo-secao {
    font-size: 7.5pt;
    padding: 0.8mm;
    }

    .linha-data > div {
    border-width: 1mm;
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

    @media print {
    @page {
    size: landscape;
    }
    }
  </style>
  </head>
  <body>
	<!--<xsl:variable name="qtdReuniaoMeioSemana" select="count(root/semanas/Estrutura/ReuniaoMeioSemana[number(substring(text(), 6, 2)) = $mes])"/> -->
 <xsl:variable name="qtdReuniaoMeioSemana" select="count(root/semanas/Estrutura/Mes[number(text()) = $mes])"/>
	<xsl:if test="$qtdReuniaoMeioSemana = 4">
		<div class="A4landscape">
			<xsl:call-template name="Header">
			  <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
			</xsl:call-template>
			<table style="width:100%;">
				<tr>
					<td style="width:50%;">
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='1'/>
						</xsl:call-template>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='2'/>
						</xsl:call-template>
					</td>
					<td>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='3'/>
						</xsl:call-template>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='4'/>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
	</xsl:if>
	<xsl:if test="$qtdReuniaoMeioSemana = 5">
		<div class="A4Landscape">
			<xsl:call-template name="Header">
			  <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
			</xsl:call-template>
			<table style="width:100%;">
				<tr>
					<td style="width:50%;">
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='1'/>
						</xsl:call-template>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='2'/>
						</xsl:call-template>
					</td>
					<td>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='3'/>
						</xsl:call-template>
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='4'/>
						</xsl:call-template>
					</td>
				</tr>
			</table>
		</div>
		<div class="A4Landscape">
			<xsl:call-template name="Header">
			  <xsl:with-param name="titulo" select='"Nossa Vida e Ministério Cristão"'/>
			</xsl:call-template>
			<table style="width:100%;">
				<tr>
					<td style="width:50%;">
						<xsl:call-template name="NVMC_Item">
						  <xsl:with-param name="idx" select='5'/>
						</xsl:call-template>
					</td>
					<td style="width:50%;">
					</td>
				</tr>
			</table>
		</div>
	</xsl:if>
	</body>
</html>
</xsl:template>
</xsl:stylesheet>