# Hash Table
A hash table is a means of tracking data where it is easy to look up by value. The table contains Key-Value pairs. Each Key is run through a 'hashing' algorithm to find the location in the table where it should be stored. If two keys produce the same value, they both will be stored in the same location as part of a linked list on the table.

## Implentation
For this table, I have an algorithm that will track places so 'cat' and 'act' will not collide. Each buckett is a linked list and a collision will add to the linked list. Each Key-Value pair is of type string-int. This table holds 4327 buckets.