<?xml version = '1.0' encoding = 'ASCII' ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:uFN="uFN" version="2.0">

<xsl:function name="uFN:first-upper">
  <xsl:param name="value"/>
  <xsl:sequence select="concat(upper-case(substring($value, 1, 1)), substring($value, 2))"/>
</xsl:function>

<xsl:function name="uFN:first-lower">
  <xsl:param name="value"/>
  <xsl:sequence select="concat(lower-case(substring($value, 1, 1)), substring($value, 2))"/>
</xsl:function>

<xsl:function name="uFN:default-init">
  <xsl:param name="value"/>
  <xsl:choose>
    <xsl:when test="$value = 'int'">
      <xsl:sequence select="'0'"/>
    </xsl:when>
    <xsl:when test="$value = 'double'">
      <xsl:sequence select="'0'"/>
    </xsl:when>
    <xsl:when test="$value = 'bool'">
      <xsl:sequence select="'false'"/>
    </xsl:when>
    <xsl:when test="$value = 'boolean'">
      <xsl:sequence select="'false'"/>
    </xsl:when>
    <xsl:when test="$value = 'Boolean'">
      <xsl:sequence select="'false'"/>
    </xsl:when>
    <xsl:when test="$value = 'string'">
      <xsl:sequence select="'string.Empty'"/>
    </xsl:when>
    <xsl:when test="$value = 'DateTime'">
      <xsl:sequence select="'new DateTime(0)'"/>
    </xsl:when>
   <xsl:when test="$value = 'decimal'">
      <xsl:sequence select="'0'"/>
    </xsl:when>
    <xsl:otherwise>
      <xsl:sequence select="'null'"/>
    </xsl:otherwise>
  </xsl:choose>
</xsl:function>

<xsl:function name="uFN:database-type">
  <xsl:param name="attributeType"/>
  <xsl:choose>
    <xsl:when test="$attributeType = 'DateTime'">
      <xsl:sequence select="'datetime'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'bool' or $attributeType = 'Boolean'">
      <xsl:sequence select="'bit'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'float' or $attributeType = 'double'">
      <xsl:sequence select="'float'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'int'">
      <xsl:sequence select="'int'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'byte[]'">
      <xsl:sequence select="'varbinary(max)'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'string' or $attributeType = 'String'">
      <xsl:sequence select="'nvarchar(255)'"/>
    </xsl:when>
    <xsl:when test="$attributeType = 'decimal' or $attributeType = 'Decimal'">
      <xsl:sequence select="'decimal(10,2)'"/>
    </xsl:when>
    <xsl:otherwise>
      <xsl:sequence select="concat('unknown: ', $attributeType)"/>
    </xsl:otherwise>
  </xsl:choose>
</xsl:function>
</xsl:stylesheet>
