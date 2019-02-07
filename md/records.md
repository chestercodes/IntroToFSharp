## Records

Records represent simple aggregates of named values, optionally with members.

``` fs
[ attributes ]
type [accessibility-modifier] typename =
    { [ mutable ] label1 : type1;
      [ mutable ] label2 : type2;
      ... }
    [ member-list ]
```

---

### Scenario

Want to model and compare data in an immutable way.

Need to store info about a person (name, age) and their address (line 1,2 postcode).


---?code=code/record/john.cs&lang=cs

@[22-41](Class to store a person's address)
@[1-20](Class to store a person's info)
@[1,14,18](Structural comparison requires extras)

@[47-56](Assign some johns and compare)

@[58-64](Mutating requires lots of boilerplate)

---?code=code/record/john.fsx&lang=fs

@[1](Record to store a person's address)
@[3-5](Class to store a person's info)

@[7-15](Assign some johns and compare, no extras needed)

@[17-18](Mutating uses with keyword to specify difference and copies rest)

---
