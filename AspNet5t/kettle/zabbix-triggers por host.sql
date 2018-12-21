SELECT * FROM triggers tr WHERE tr.triggerid in (
SELECT
  f.triggerid
FROM functions f
  INNER JOIN items
    ON f.itemid = items.itemid
  INNER JOIN hosts
    ON items.hostid = hosts.hostid
GROUP BY f.triggerid
  HAVING MIN(hosts.name) LIKE 'coletor-temperatura')