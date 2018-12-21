SELECT
  history_uint.itemid,
  history_uint.clock,
  FROM_UNIXTIME(history_uint.clock) AS tm,
  history_uint.value,
  history_uint.ns,
  items.name,
  items.multiplier,
  hosts.host
FROM history_uint
  LEFT OUTER JOIN items
    ON history_uint.itemid = items.itemid
  LEFT OUTER JOIN hosts
    ON items.hostid = hosts.hostid
WHERE history_uint.itemid in (25834,25872)
AND history_uint.clock BETWEEN UNIX_TIMESTAMP('2017-06-20 09:00') AND UNIX_TIMESTAMP('2017-06-20 10:00')