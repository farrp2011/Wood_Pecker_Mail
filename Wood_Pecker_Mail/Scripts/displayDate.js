


function displayDate(idName, date)
{
    document.getElementById(idName).innerHTML = new Date(date * 1000);
}