type Email = Email of string
let createEmail email = 
    // plus validation
    Email email

type Phone = Phone of string
let createPhone phone = 
    // plus validation
    Phone phone

type Contact = 
    | Email of Email
    | Phone of Phone
    | EmailAndPhone of Email * Phone

let email = createEmail "some@email.com"
let phone = createPhone "01234 567890"

let emailOnlyContact = Email email
let phoneOnlyContact = Phone phone
let emailAndPhoneContact = EmailAndPhone (email, phone)