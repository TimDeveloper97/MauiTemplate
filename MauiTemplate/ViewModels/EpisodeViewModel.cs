using MauiTemplate.Models;
using MvvmHelpers.Commands;
using MvvmHelpers.Interfaces;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTemplate.ViewModels
{
    public class EpisodeViewModel : BaseViewModel
    {
        //private readonly PlayerService playerService;
        private Episode episode;

        public bool IsInListenLater
        {
            get
            {
                return episode.IsInListenLater;
            }
            set
            {
                episode.IsInListenLater = value;
                OnPropertyChanged();
            }
        }

        public Episode Episode
        {
            get { return episode; }
            set { SetProperty(ref episode, value); }
        }

        public Show Show { get; set; }

        public IAsyncCommand PlayEpisodeCommand { get; private set; }

        public IAsyncCommand NavigateToDetailCommand { get; private set; }

        public EpisodeViewModel(
            Episode episode,
            Show show)
        {
            //playerService = player;

            Episode = episode;
            Show = show;
            PlayEpisodeCommand = new AsyncCommand(PlayEpisodeCommandExecute);
            NavigateToDetailCommand = new AsyncCommand(NavigateToDetailCommandExecute);
        }

        private Task PlayEpisodeCommandExecute() => null;

        private Task NavigateToDetailCommandExecute() => null;
    }
}
