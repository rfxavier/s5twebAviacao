SELECT
  MAX(itemid) itemid,
  MAX(clock) clock,
 FROM_UNIXTIME(MAX(clock)) AS tm,
  MAX(value) value
FROM history_uint
WHERE history_uint.itemid IN (25690)
AND history_uint.clock BETWEEN UNIX_TIMESTAMP('2017-06-18 00:00') AND UNIX_TIMESTAMP('2017-06-18 23:59')
GROUP BY value
  ORDER BY clock