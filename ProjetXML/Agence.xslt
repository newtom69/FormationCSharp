<?xml version="1.0" encoding="UTF-8" ?>
<!-- le prologue -->

<!-- l'élément racine -->
<xsl:stylesheet version="1.0 " xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <!-- l'élément output -->
  <xsl:output
    method="html"
    encoding="UTF-8"
    doctype-public="-//W3C//DTD HTML 4.01//EN"
    doctype-system="http://www.w3.org/TR/html4/strict.dtd"
    indent="yes"></xsl:output>
  <!-- reste du document XSLT -->


    <xsl:template match="/">
      <table>
 <xsl:for-each select="salle/personne">
              <xsl:if test="@civilite = 'homme'">
                <xsl:copy-of select="."></xsl:copy-of>
              </xsl:if>
            </xsl:for-each>

      </table>
    </xsl:template>


</xsl:stylesheet>



