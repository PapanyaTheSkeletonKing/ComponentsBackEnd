import React from 'react'
import {profileAPI} from "../../api/api"
// import s from './News.module.css'
class News extends React.Component {

    constructor(props) {
        super(props);
        this.state = ({initialized : false});
    }

    render() {
        if (!this.state.initialized){
            return <h1>Page is loading.</h1>
        }
        return (
            <div>
                News { this.state.news }
            </div>
        );
    }

    componentDidMount() {
        fetch("https://localhost:5001/news/")
            .then(response => {
                    return response.json();
            })
            .then(async data => {
                await this.setState(
                    {news: JSON.stringify(data) , initialized : true})
            })
            .catch((error) => window.alert(error));
    }
}

export default News;