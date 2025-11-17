use('test');

db.sales.insertOne({ item: 'test', price: 10 })
db.sales.insertOne({ item: 'test2', price: 11 })
db.sales.insertOne({ item: 'test3', price: 12})

db.sales.find({ item: 'test3' })
db.sales.find({ item: 'test'}, {price: 1}).sort()

