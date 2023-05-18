<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>List of events</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Name</th>
            <th>Date</th>
          </tr>
          <xsl:for-each select="action/event">
            <tr>
              <xsl:if test="position() mod 2 = 0">
                <xsl:attribute name="bgcolor">#CCCCCC</xsl:attribute>
              </xsl:if>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="date"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>