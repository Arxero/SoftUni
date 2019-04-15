/* TODO: 
	create phonebook array
	add methods for adding in the phonebook and getting it
	export the methods
*/

let phonebook = []

function getPhoneBook() {
    return phonebook
}

function addContact(contact) {
    phonebook.push(contact)
}

module.exports = {
    getPhoneBook,
    addContact
}