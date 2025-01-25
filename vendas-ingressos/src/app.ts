import express from 'express';
import * as mysql from 'mysql2/promise';
import bcrypt from 'bcrypt';

// criação da conecção do banco de dados
function createConnection(){
    return mysql.createConnection({
        host: 'localhost',
        user: 'root',
        password: 'root',
        database: 'tickets'
    })
}

const app = express()

app.use(express.json())

app.get("/", (req, res) => {
    res.json({message: "Hello World"});
});

app.post("/auth/login", (req, res) => {
    const {email, password} = req.body;
    console.log(`email = ${email}, password = ${password}`);
    res.send();
});

app.post("/partners", async (req, res) => {
    const { name, email, password, company_name } = req.body;
    
    const connection = await createConnection();

    const createdAt = new Date();
    connection.execute('INSERT INTO users (name, email, password, created_at)', [
        name, email,,createdAt
    ]);

    connection.execute('INSERT INTO partners (user_id, company_name, created_at)', [
        
    ]);
});

app.post("/partners/events", (req, res) => {
    const { name, description, date, location } = req.body;
    res.send();
});

app.get("/partners/events", (req, res) => {
    console.log();
})

app.get("/partners/events:eventsId", (req, res) => {
    const { eventsId } = req.params;
    console.log(eventsId);
    res.send();
});

app.post("/customers", (req, res) => {
    const { name, email, password, address, phone_number} = req.body;
    res.send();
});

app.post("/events", (req, res) => {
    const { name, description, date, location } = req.body;
    res.send();
});

app.get("/events", (req, res) => {
    console.log();
})

app.get("/events:eventsId", (req, res) => {
    const { eventsId } = req.params;
    console.log(eventsId);
    res.send();
});

app.listen(3000, () => {
    console.log("running in http://localhost:3000");
});
