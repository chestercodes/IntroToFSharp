
## Units of measure

![MarsRover](assets/marsRover.jpg)

---

@quote[NASA's $125 million Mars Climate Orbiter project ended in failure when the orbiter dipped 90 km closer to Mars than originally intended, causing it to tear apart and disintegrate spectacularly in the Mars atmosphere. ... the root cause of the problem to a conversion error ... NASA passed data to the systems in metric units, but the software expected data in Imperial units.]

---

@quote[Units-of-measure are to science what types are to programming.]

--- 

### Scenario

Usage and conversion of degrees and radians

![Radians](assets/rads.png)


---?code=code/uom/rad.fsx&lang=fs

@[1-2](Define units of measure, radian and degree)
@[1-5](Assign values of different measures)
@[7](Conversion factor to convert between measures.)
@[4-10](Can add twoRad to oneHundredDeg with conversion)
@[12](Trying to add values doesn't compile )

---?code=code/uom/bank.fsx&lang=fs

@[1-10](Define units of measure)
@[13-22](Bank info and record)
@[24-36](Function to parse csv line or None)
@[28-29](Matches to array with 3 parts)
@[25-26,30-31](Matches to successful float and int parsing)
@[22,32-34](Bank info record)
@[38-41](Parse csv to bank infos)
@[43-49](Function to compound interest, takes rate and years as args)
@[51-54](Function to calculate amount after years)
@[56-67](Calculate amounts for bank infos)


---

