# Hash Table
A hash table is a means of tracking data where it is easy to look up by value. The table contains Key-Value pairs. Each Key is run through a 'hashing' algorithm to find the location in the table where it should be stored. If two keys produce the same value, they both will be stored in the same location as part of a linked list on the table.

## Implentation
This table accepts Key-Value pairs that are of type 'string-int'. Each bucket is a linked list, so when collisions occur the new value is added to the linked list in the buckett. The hashing algorithm is order dependent, so 'cat' and 'act' will not collide. Last but not least, if an excessively large key is passed it is possible to overflow the value of int for the key and potentially cause problems. 