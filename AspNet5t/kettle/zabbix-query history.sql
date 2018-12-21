SELECT
  history.itemid,
  history.clock,
  FROM_UNIXTIME(history.clock) AS tm,
  history.value,
  history.ns,
  items.name,
  items.multiplier,
  hosts.host
FROM history
  LEFT OUTER JOIN items
    ON history.itemid = items.itemid
  LEFT OUTER JOIN hosts
    ON items.hostid = hosts.hostid
WHERE history.itemid in (25677,25679)
AND history.clock BETWEEN UNIX_TIMESTAMP('2017-06-12 00:00') AND UNIX_TIMESTAMP('2017-06-16 23:59')