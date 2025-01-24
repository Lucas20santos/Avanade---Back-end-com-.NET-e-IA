import express from 'express';

const app = express()


app.get("/", (req, res) => {
    res.json({message: "Hello World"});
});

app.post("/auth/login", (req, res) => {
    const {email, password} = req.body;
    console.log(`name = ${email}, password = ${password}`);
    res.send();
});

app.listen(3000, () => {
    console.log("running in http://localhost:3000");
});
