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
    
    try
    {
        const createdAt = new Date();
        const hashedPassword = bcrypt.hashSync(password, 10);

        const [ userResult ] = await connection.execute<mysql.ResultSetHeader>('INSERT INTO users (name, email, password, created_at)', [
            name, email,hashedPassword,createdAt
        ]);
        const userId = userResult.insertId;

        const [ partnersResult ] = await connection.execute<mysql.ResultSetHeader>(
            'INSERT INTO partners (user_id, company_name, created_at)', 
            [userId, company_name, createdAt]
        );
        res.status(201).json({id: partnersResult.insertId, userId, company_name, createdAt})
    }finally
    {
        await connection.end();
    }
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
