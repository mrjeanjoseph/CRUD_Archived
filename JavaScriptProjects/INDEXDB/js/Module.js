

const productdb = (dbname, table) => {
    //Create database
    const db = new Dexie(dbname);
    db.version(1).stores(table);
    db.open();

    return db;
}

//insert function 
const bulkcreate = (dbtable, data) => {
    let flag = empty(data);
    if(flag) {
        dbtable.bulkAdd([data]);
        console.log("Data inserted successfully...!");
    } else {
        console.log("Please provide Data...!");
    }
    return flag;
}

//check textbox validation
const empty = object => {
    let flag = false;

    for(const value in object) {
        if(object[value] != "" && object.hasOwnProperty(value)){
            flag = true;
        } else {
            flag = false;
        }
    }
    return flag;
}

//Fetch qty of data from db
const getData = (dbtable, fn) => {
    let index = 0;
    let obj = {};

    dbtable.count((count) => {
        if(count) {
            dbtable.each(table => {
                obj = sortObject(table);
                
            })
        }
    })
}

//sort object
const sortObject = dataObj => {
    let objSorted = {};

    objSorted = {
        id: dataObj.id,
        name: dataObj.name,
        seller: dataObj.seller,
        price: dataObj.price
    }
    return objSorted;
}

export default productdb;
export {
    bulkcreate,
}