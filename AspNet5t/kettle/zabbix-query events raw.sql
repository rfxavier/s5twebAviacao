SELECT
  events.objectid,
  events.clock,
  events.value,
  events.acknowledged,
  triggers.description,
  triggers.triggerid,
  functions.itemid,
  items.name
FROM events
  INNER JOIN triggers
    ON events.objectid = triggers.triggerid
  INNER JOIN functions
    ON functions.triggerid = triggers.triggerid
  INNER JOIN items
    ON functions.itemid = items.itemid
WHERE events.source = 0
AND events.object = 0
AND events.eventid = 6307975
ORDER BY events.clock DESC