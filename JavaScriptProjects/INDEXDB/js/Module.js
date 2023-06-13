

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

export default productdb;
export {
    bulkcreate,
}