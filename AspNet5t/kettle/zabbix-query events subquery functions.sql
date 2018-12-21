SELECT
         events.objectid,
         events.clock,
         events.value,
         events.acknowledged,
         triggers.description,
         triggers.triggerid,
         functions.hostname
       FROM events
         INNER JOIN triggers
           ON events.objectid = triggers.triggerid
         INNER JOIN (SELECT
             MIN(hosts.name) AS hostname
           FROM functions
             INNER JOIN items
               ON functions.itemid = items.itemid
             INNER JOIN hosts
               ON items.hostid = hosts.hostid) functions
         WHERE events.source = 0
         AND events.object = 0
         AND events.eventid = 6307975
         ORDER BY events.clock DESC