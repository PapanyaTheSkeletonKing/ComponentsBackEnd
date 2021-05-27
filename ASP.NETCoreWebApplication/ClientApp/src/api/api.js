import axios from 'axios';

const URL = "https://localhost:5001/";

const instanse = axios.create({
    withCredentials: true,
    baseURL: 'https://social-network.samuraijs.com/api/1.0/',
    headers: {
        "API-KEY": "be5c96f6-d618-4264-9a0a-7fa2d3b5f578"
    }
})

export const usersAPI = {
    getUsers(currentPage = 1, pageSize = 10) {
        return instanse.get(`users?page=${currentPage}&count=${pageSize}`)
            .then(response => {
                return response.data;
            });
    },
    follow(userId) {
        return instanse.post(`follow/${userId}`)
    },
    unfollow(userId) {
        return instanse.delete(`follow/${userId}`)
    },
    getProfile(userId) {
        console.warn('Obsolete method. Please profileAPI object.')
        return profileAPI.getProfile(userId);
    }
}

export const profileAPI = {
    async getNews(){
      const response = await fetch(URL + "news/");
      return await response.json()
    },
    async getProfile(userId) {
        const response = await fetch(URL + "user/" + userId);
        return JSON.parse(await response.json());
    },
    getStatus(userId) {
        return instanse.get(`profile/status/` + userId);
    },
    updateStatus(status) {
        return instanse.put(`profile/status`, { status: status });
    },
    //dlya fotok
    getPhoto(){

    },
    savePhoto(photoFile) {
        const formData = new FormData();
        formData.append('image', photoFile)
        return instanse.put("profile/photo/", formData, {
            headers: {
                'Content-Type': 'multipart/form-data'
            }
        })
    },
    saveProfile(profile) {
        return instanse.put('profile', profile);
    }
}

export const authAPI = {
    me() {
        return instanse.get(`auth/me`);
    },
    async login(email, password, rememberMe = false, captcha = null) {
        return await fetch(URL + "auth/login?email=" + email + "&password=" + password);
    },
    logout() {
        return instanse.delete(`auth/login`);
    }
    //https://localhost:5001/auth/login?email=zhukovets.vetal322@gmail.com&password=1
}

export const securityAPI = {
    getCaptchaURL() {
        return instanse.get(`security/get-captcha-url`)
    }
}

