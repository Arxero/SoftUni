function rest(avaiableRooms, allGuests) {
    let rooms = new Map();
    for (let room of avaiableRooms) {
        let roomSpace = room.type == 'double-bedded' ? 2 : 3;
        rooms.set(room.number, { type: room.type, emptyBeds: roomSpace });
    }

    for (let currentPair of allGuests) {
        let roomFound = false;
        if (currentPair.first.gender != currentPair.second.gender) {
            for (let [key, value] of rooms) {
                if (value.type == 'double-bedded' && value.emptyBeds == 2) {
                    value.allGuests = [];
                    value.allGuests = [currentPair.first, currentPair.second];
                    value.emptyBeds = 0;
                    roomFound = true;
                    break;
                }
            }
        }else {
            for (let [key, value] of rooms) {
                if (value.type == 'triple' && value.emptyBeds > 1) {
                    if (value.allGuests == undefined) {
                        value.allGuests = [];
                    }else if (value.allGuests[0].gender != currentPair.second.gender) {
                        continue;
                    }
                }
            }
        }
    }
}
rest(
    [{ number: '206', type: 'double-bedded' },
    { number: '311', type: 'triple' }],

    [{
        first: { name: 'Tanya Popova', gender: 'female', age: 24 },
        second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 }
    },
    {
        first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
        second: { name: 'Angel Nachev', gender: 'male', age: 22 }
    },
    {
        first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
        second: { name: 'Boryana Baeva', gender: 'female', age: 22 }
    }]
);