function proceedDialog(primaryControl) {
    let formContext = primaryControl;
	let answer = window.confirm("Are you sure to save the record");
    if (answer) {
        //some code
        alert("Yes");
		formContext.data.entity.save();  
    } else {
        //some code
        alert("No");
    }
}