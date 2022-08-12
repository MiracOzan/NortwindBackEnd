import React, { Component } from 'react'
import { variables } from '../variables';

export default class Employees extends Component {
  
    constructor(props){
        super(props);
    
        this.state={
            employees:[]
        }
      }

    refleshList(){
        fetch(variables.API_URL + 'employes/GetAll')
        .then(response=>response.json())
        .then(data=>{
            this.setState({employees:data})
        })
    }
    componentDidMount(){
        this.refleshList();
    }
    render() {
        const {
            employees,
            EmployeeID,
            FirstName,
            LastName,
            Title,
            TitleOfCourtesy,
            BirthDate,
            Address,
            City,
            Region,
            PostalCode,
            Country,
            HomePhone,
            Extension,
            Photo,
            ReportsTo
        }=this.state
        return (
           <div>
            
           </div>
        )
    }
}
