const socketio = require('socket.io');

const io = socketio.listen(3000);

io.on('connection', (socket) => {

    io.emit('connection done', {value: 'hoge'});

    socket.on('sendValueToServer', (data) => {
        io.emit('sendResultToClient', {value: data.value});
    })

    socket.on('disconnect', () => {
        console.log('dis connect');
        io.emit('sendErrorMessage', {value: 'error'})
    })
});