namespace fs.Shared

type Address = { Line1: string; Line2: string; PostCode: string }

type Email = Email of string
type Phone = Phone of string
type Contact = 
    | JustEmail of Email
    | JustPhone of Phone
    | EmailAndPhone of Email * Phone

module Utils =
    let contactInfoToString contact =
        match contact with
        | JustEmail email -> "Is Just Email"
        | JustPhone phone -> "Is Just Phone"
        | EmailAndPhone (email, phone) -> "Is Email and phone"