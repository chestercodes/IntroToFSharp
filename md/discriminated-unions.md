![Number room](assets/number.jpg)

## Discriminated unions

![Suite](assets/suite.jpg)


---?code=code/du/hotel.fsx&lang=fs

@[1-5](Define hotel room type)
@[7-10](Construct values of type)
@[12-16](Function to print names)
@[2,3,8,12-14](Number case match)
@[2,4,9,12-13,15](Name case match)
@[2,5,10,12-13,16](Reception case match)
@[8-20](Function invoked with RoomName values)


---?code=code/du/comms.cs&lang=cs

@[1-9](Class to contain email address)
@[11-19](Class to contain phone number)
@[21-35](Contact information)
@[27-31](Throws if neither email or phone)
@[41-51](Instantiation of different contact objects)
@[50-51](Possible runtime error)


---?code=code/du/comms.fsx&lang=fs

@[1-4](Discriminated union to hold email)
@[6-9](Discriminated union to hold phone)
@[11-14](Contact type)
@[12](Just Email)
@[13](Just Phone)
@[14](EmailAndPhone is a tuple of Email and Phone)
@[11-14](No compilable way to have neither phone or email)
@[16-21](Creation of different named contacts)


