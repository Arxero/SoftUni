let subscriptions = {
    'loginUser': [],
    'notification': [],
    'userToken': [],
}

export default {
    events: {
        loginUser: 'loginUser',
        notification: 'notification',
        userToken: 'userToken'
    },
    subscribe: (eventName, fn) => subscriptions[eventName].push(fn),
    trigger: (eventName, data) => subscriptions[eventName].forEach(fn => fn(data))
}