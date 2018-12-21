SELECT
  hosts.host,
  items.*
FROM items
  INNER JOIN hosts
    ON items.hostid = hosts.hostid
WHERE items.hostid IN (10152, 10155)
ORDER BY items.name